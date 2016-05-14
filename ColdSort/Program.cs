using ColdSort.Controllers;
using ColdSort.Core.Interfaces.Controllers;
using ColdSort.Views;
using System;
using System.Windows.Forms;

namespace ColdSort
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            using (MainView mainView = new MainView())
            {
                mainView.Visible = false;
                IMainController mainController = new MainController(mainView);
                mainController.LoadView();
                Application.Run();
            }
        }
    }
}
