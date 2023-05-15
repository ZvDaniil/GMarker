using GMarker.UI.Views;
using GMarker.UI.Presenters;

namespace GMarker.UI.Factories
{
    /// <summary>
    /// Интерфейс фабрики для создания презентера UnitPresenter.
    /// </summary>
    public interface IUnitPresenterFactory
    {
        /// <summary>
        /// Создает презентер UnitPresenter для указанного представления IUnitView.
        /// </summary>
        /// <param name="view">Представление IUnitView.</param>
        /// <returns>Созданный презентер UnitPresenter.</returns>
        UnitPresenter Create(IUnitView view);
    }
}
