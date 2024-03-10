using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms
{
    internal class MainFormController : IDisposable
    {
        private readonly MainFormModel _model;
        private readonly MainForm _view;
        private int _xCoordinates;
        private int _yCoordinates;
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
        }

        private void _view_Load(object sender, EventArgs e)
        {
            var timeTeller = new TimeTeller(_view.DateTimePicker.Value);
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

        public void Dispose()
        {
            _view.SizeChanged -= _view_SizeChanged;
            _view.TableLayoutPanel.MouseMove -= _view_MouseMove;
        }
    }
}
