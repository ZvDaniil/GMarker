using System;

namespace GMarker.Domain.Models
{
    /// <summary>
    /// Предоставляет данные события, связанные с экземпляром класса Unit.
    /// </summary>
    public class UnitEventArgs : EventArgs
    {
        /// <summary>
        /// Экземпляр класса Unit, связанный с событием.
        /// </summary>
        public Unit Unit { get; private set; }

        /// <summary>
        /// Инициализирует новый экземпляр класса UnitEventArgs с указанным экземпляром класса Unit.
        /// </summary>
        /// <param name="unit">Экземпляр класса Unit, связанный с событием.</param>
        public UnitEventArgs(Unit unit) => Unit = unit;
    }
}