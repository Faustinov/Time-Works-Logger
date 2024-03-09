using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms
{
    internal class MainFormController
    {
        private readonly MainFormModel _model;
        private readonly MainForm _view;
        public MainFormController(MainFormModel model, MainForm view)
        {
            _model = model;
            _view = view;

            InitializeEvents();
        }

        private void InitializeEvents()
        {
            _view.Click += _view_Click;
        }
        int i;
        private void _view_Click(object sender, EventArgs e)
        {
        }
    }
}
