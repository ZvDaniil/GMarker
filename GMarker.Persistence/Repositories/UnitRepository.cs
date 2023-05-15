using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;

using GMarker.Domain.Models;
using GMarker.Application.Interfaces;
using GMarker.Persistence.Extensions;

namespace GMarker.Persistence.Repositories
{
    /// <summary>
    /// Репозиторий для управления сущностями Unit.
    /// </summary>
    internal class UnitRepository : IUnitRepository, IDisposable
    {
        private readonly IDbConnection _connection;
        private IDbTransaction _transaction;
        private bool _disposed;

        /// <summary>
        /// Конструктор репозитория.
        /// </summary>
        /// <param name="connectionString">Строка подключения к базе данных.</param>
        public UnitRepository(string connectionString)
        {
            _connection = new SqlConnection(connectionString);
            _connection.Open();
            _transaction = _connection.BeginTransaction();
        }

        /// <inheritdoc />
        public IEnumerable<Unit> GetAll()
        {
            var units = new List<Unit>();
            var sql = "SELECT * FROM Units";

            using (var command = _connection.CreateCommand())
            {
                command.Transaction = _transaction;
                command.CommandText = sql;

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var unit = new Unit
                        {
                            Id = (int)reader["Id"],
                            Name = (string)reader["Name"],
                            Latitude = (double)reader["Latitude"],
                            Longitude = (double)reader["Longitude"]
                        };

                        units.Add(unit);
                    }
                }
            }

            return units;
        }

        /// <inheritdoc />
        public void Update(Unit unit)
        {
            var sql = "UPDATE Units SET Name = @Name, Latitude = @Latitude, Longitude = @Longitude WHERE Id = @Id";
            using (var command = _connection.CreateCommand())
            {
                command.Transaction = _transaction;
                command.CommandText = sql;

                command.AddParameter("@Name", unit.Name);
                command.AddParameter("@Latitude", unit.Latitude);
                command.AddParameter("@Longitude", unit.Longitude);
                command.AddParameter("@Id", unit.Id);

                command.ExecuteNonQuery();
            }
        }

        /// <inheritdoc />
        public void SaveChanges()
        {
            try
            {
                _transaction.Commit();
            }
            catch
            {
                _transaction.Rollback();
                throw;
            }
            finally
            {
                _transaction.Dispose();
                _transaction = _connection.BeginTransaction();
            }
        }

        /// <inheritdoc />
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    _transaction?.Dispose();
                    _connection?.Dispose();
                }
                _disposed = true;
            }
        }
    }
}
