using System;
using GMarker.Domain.Models;

namespace GMarker.UI.Views
{
    /// <summary>
    /// Интерфейс представления для отображения юнитов.
    /// </summary>
    public interface IUnitView
    {
        /// <summary>
        /// Событие, возникающее при загрузке представления.
        /// </summary>
        event EventHandler Load;

        /// <summary>
        /// Событие, возникающее при перемещении юнита.
        /// </summary>
        event EventHandler<UnitEventArgs> UnitMoved;

        /// <summary>
        /// Добавляет юнит в представление.
        /// </summary>
        /// <param name="unit">Добавляемый юнит.</param>
        void AddUnit(Unit unit);
    }
}
