using GMarker.Application.Interfaces;
using GMarker.UI.Views;
using GMarker.UI.Presenters;

namespace GMarker.UI.Factories
{
    /// <summary>
    /// Фабрика для создания презентера UnitPresenter.
    /// </summary>
    public class UnitPresenterFactory : IUnitPresenterFactory
    {
        private readonly IUnitRepository _unitRepository;

        /// <summary>
        /// Инициализирует новый экземпляр класса UnitPresenterFactory с указанным репозиторием IUnitRepository.
        /// </summary>
        /// <param name="unitRepository">Репозиторий IUnitRepository для использования в презентере.</param>
        public UnitPresenterFactory(IUnitRepository unitRepository) =>
            _unitRepository = unitRepository;

        ///<inheritdoc/>
        public UnitPresenter Create(IUnitView view) =>
            new UnitPresenter(view, _unitRepository);
    }
}