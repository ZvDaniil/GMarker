using System;
using System.Windows.Forms;

using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms.Markers;

using GMarker.Domain.Models;
using GMarker.UI.Views;
using GMarker.UI.Presenters;
using GMarker.UI.Factories;

namespace GMarker.UI
{
    public partial class MainForm : Form, IUnitView
    {
        private readonly UnitPresenter _unitPresenter;

        private GMapControl _map;
        private GMapOverlay _mapOverlay;

        private bool _isMarkerDragging = false;
        private GMapMarker _selectedMarker = null;

        public event EventHandler<UnitEventArgs> UnitMoved;

        public MainForm(IUnitPresenterFactory unitPresenterFactory)
        {
            InitializeComponent();

            _unitPresenter = unitPresenterFactory.Create(this);
            _saveChangesBtn.Click += (s, e) =>
            {
                _unitPresenter.OnSaveChanges(s, e);
                _saveChangesBtn.Visible = false;
            };

            InitializeMap();
        }

        private void InitializeMap()
        {
            _map = new GMapControl
            {
                Dock = DockStyle.Fill,
                MapProvider = GMapProviders.GoogleMap,
                Position = new PointLatLng(55.7504461, 37.6174943),
                CanDragMap = true,
                DragButton = MouseButtons.Left,
                MinZoom = 1,
                MaxZoom = 18,
                Zoom = 10,
            };

            _mapOverlay = new GMapOverlay("units");
            _map.Overlays.Add(_mapOverlay);

            _map.OnMarkerEnter += (marker) => _selectedMarker = marker;
            _map.OnMarkerLeave += (marker) => _selectedMarker = null;

            _map.MouseDown += Map_MouseDown;
            _map.MouseMove += Map_MouseMove;
            _map.MouseUp += Map_MouseUp;

            this.Controls.Add(_map);
        }

        public void AddUnit(Unit unit)
        {
            var pointLatLang = new PointLatLng(unit.Latitude, unit.Longitude);
            var marker = new GMarkerGoogle(pointLatLang, GMarkerGoogleType.blue) { Tag = unit };

            _mapOverlay.Markers.Add(marker);
            _map.Refresh();
        }

        private void Map_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && _selectedMarker != null)
            {
                _isMarkerDragging = true;
                _saveChangesBtn.Visible = true;
            }
        }

        private void Map_MouseMove(object sender, MouseEventArgs e)
        {
            if (_isMarkerDragging)
            {
                _selectedMarker.Position = _map.FromLocalToLatLng(e.X, e.Y);
            }
        }

        private void Map_MouseUp(object sender, MouseEventArgs e)
        {
            if (_isMarkerDragging && _selectedMarker.Tag is Unit unit)
            {
                _isMarkerDragging = false;

                unit.Latitude = _selectedMarker.Position.Lat;
                unit.Longitude = _selectedMarker.Position.Lng;

                UnitMoved?.Invoke(this, new UnitEventArgs(unit));
            }
        }
    }
}