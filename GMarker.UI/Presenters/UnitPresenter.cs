using System;
using GMarker.Application.Interfaces;
using GMarker.Domain.Models;
using GMarker.UI.Views;

namespace GMarker.UI.Presenters
{
    /// <summary>
    /// Презентер для управления представлением IUnitView.
    /// </summary>
    public class UnitPresenter
    {
        private readonly IUnitView _view;
        private readonly IUnitRepository _unitRepository;

        /// <summary>
        /// Инициализирует новый экземпляр класса UnitPresenter с указанным представлением и репозиторием.
        /// </summary>
        /// <param name="view">Представление IUnitView.</param>
        /// <param name="unitRepository">Репозиторий IUnitRepository.</param>
        public UnitPresenter(IUnitView view, IUnitRepository unitRepository)
        {
            _view = view;
            _unitRepository = unitRepository;

            _view.Load += OnLoad;
            _view.UnitMoved += OnUnitMoved;
        }

        /// <summary>
        /// Обработчик события загрузки представления.
        /// Загружает все юниты из репозитория и добавляет их в представление.
        /// </summary>
        private void OnLoad(object sender, EventArgs e)
        {
            var units = _unitRepository.GetAll();
            foreach (var unit in units)
            {
                _view.AddUnit(unit);
            }
        }

        /// <summary>
        /// Обработчик события сохранения изменений.
        /// Сохраняет изменения в репозитории.
        /// </summary>
        public void OnSaveChanges(object sender, EventArgs e) =>
            _unitRepository.SaveChanges();

        /// <summary>
        /// Обработчик события перемещения юнита.
        /// Обновляет данные юнита в репозитории.
        /// </summary>
        private void OnUnitMoved(object sender, UnitEventArgs e) =>
            _unitRepository.Update(e.Unit);
    }
}
