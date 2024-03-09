using System;
using System.Threading;
using System.Windows.Forms;

namespace WinForms
{
    internal static class Program
    {
        private static MainForm s_mainForm;
        private static MainFormModel s_model;
        private static MainFormController s_mainFormController;
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            s_mainForm = new MainForm();
            s_model = new MainFormModel();
            s_mainFormController = new MainFormController(s_model, s_mainForm);
            Application.Run(s_mainForm);
        }
    }
}
