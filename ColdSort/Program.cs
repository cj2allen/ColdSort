//-----------------------------------------------------------------------
// <copyright file="Program.cs" company="None">
//     Copyright (c) 2016 Christopher James Allen
// </copyright>
// <author>Christopher James Allen</author>
//-----------------------------------------------------------------------

using System;
using System.Windows.Forms;
using ColdSort.Services;
using ColdSort.Interfaces.Controllers;
using ColdSort.Views;

namespace ColdSort
{
    /// <summary>
    /// The program class
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            using (MainView mainView = new MainView())
            {
                mainView.Visible = false;
                IMainController mainController = new MainController(mainView);
                mainController.SetupView(true);
                Application.Run();
            }
        }
    }
}
