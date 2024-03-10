using System;
using System.Linq;
using System.Windows.Forms;

namespace WinForms
{
    internal class MainFormController : IDisposable
    {
        private MainFormModel _model;
        private MainForm _view;
        private int _xCoordinates;
        private int _yCoordinates;
        public MainFormModel Model
        {
            get => _model;
            set => _model = value;
        }
        public MainForm View
        {
            get => _view;
            set => _view = value;
        }
        public MainFormController(MainFormModel model, MainForm view)
        {
            _model = model;
            _view = view;

            InitializeEvents();
        }

        private void InitializeEvents()
        {
            _view.Load += _view_Load;
            _view.SizeChanged += _view_SizeChanged;
            _view.TableLayoutPanel.MouseMove += _view_MouseMove;
            _view.ButtonSave.MouseClick += _buttonSave_MouseClick;
            _view.Label.TextChanged += _label_TextChanged;
        }

        private void _label_TextChanged(object sender, EventArgs e)
        {
            var control = sender as Control;
            if (control == null)
                return;

            _model.GeneralDateTime = control.Text;
        }

        private void _view_Load(object sender, EventArgs e)
        {
            var timeTeller = new TimeTeller(_view.DateTimePicker.Value, _model);
            timeTeller.DataHandlerAsync();
            controlFiller();
        }


        private void _buttonSave_MouseClick(object sender, MouseEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void _view_MouseMove(object sender, MouseEventArgs e)
        {
            _xCoordinates = e.X;
            _yCoordinates = e.Y;
            _view.Text = $"Логгер рабочего времени. Width: {_view.Width} Height: {_view.Height}. X = {_xCoordinates} Y = {_yCoordinates}";
        }

        private void _view_SizeChanged(object sender, EventArgs e)
        {
            _view.Text = $"Логгер рабочего времени. Width: {_view.Width} Height: {_view.Height}. X = {_xCoordinates} Y = {_yCoordinates}";
        }

        private void controlFiller()
        {
            if (_model.SpentTimes == null)
            {
                //_view.ListBox.Items.Add("Пусто");
                return;
            }

            foreach (var item in _model.SpentTimes)
            {
                _view.ListBox.Items.Add(item);
            }
        }

        public void Dispose()
        {
            _view.SizeChanged -= _view_SizeChanged;
            _view.TableLayoutPanel.MouseMove -= _view_MouseMove;
        }
    }
}
