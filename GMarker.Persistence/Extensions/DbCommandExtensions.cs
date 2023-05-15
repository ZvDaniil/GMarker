using System;
using System.Data;

namespace GMarker.Persistence.Extensions
{
    /// <summary>
    /// Расширения для IDbCommand.
    /// </summary>
    public static class DbCommandExtensions
    {
        /// <summary>
        /// Добавляет параметр в IDbCommand.
        /// </summary>
        /// <param name="command">Объект IDbCommand.</param>
        /// <param name="name">Имя параметра.</param>
        /// <param name="value">Значение параметра.</param>
        /// <remarks>Если значение равно null, то параметр будет иметь значение DBNull.Value.</remarks>
        public static void AddParameter(this IDbCommand command, string name, object value)
        {
            var parameter = command.CreateParameter();
            parameter.ParameterName = name;
            parameter.Value = value ?? DBNull.Value;
            command.Parameters.Add(parameter);
        }
    }
}
