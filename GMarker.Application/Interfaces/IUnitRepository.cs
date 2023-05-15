using System.Collections.Generic;
using GMarker.Domain.Models;

namespace GMarker.Application.Interfaces
{
    /// <summary>
    /// Интерфейс репозитория для управления сущностями Unit.
    /// </summary>
    public interface IUnitRepository
    {
        /// <summary>
        /// Получить все сущности Unit.
        /// </summary>
        /// <returns>Коллекция сущностей Unit.</returns>
        IEnumerable<Unit> GetAll();

        /// <summary>
        /// Обновить данные сущности Unit.
        /// </summary>
        /// <param name="unit">Сущность Unit с обновленными данными.</param>
        void Update(Unit unit);

        /// <summary>
        /// Сохранить все изменения в репозитории.
        /// </summary>
        void SaveChanges();
    }
}
