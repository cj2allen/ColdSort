﻿using ColdSort.Controller.Controllers;
using ColdSort.Core.Interfaces.Controllers;
using ColdSort.UI.Forms;
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
