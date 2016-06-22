//-----------------------------------------------------------------------
// <copyright file="MainView.cs" company="None">
//     Copyright (c) 2016 Christopher James Allen
// </copyright>
// <author>Christopher James Allen</author>
//-----------------------------------------------------------------------

using System;
using System.Windows.Forms;
using ColdSort.Core.Interfaces.Controllers;

namespace ColdSort.Views
{
    /// <summary>
    /// The main view form
    /// </summary>
    public partial class MainView : Form
    {
        #region Fields

        /// <summary>
        /// The main controller
        /// </summary>
        private IMainController _mainController;

        #endregion

        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="MainView"/> class
        /// </summary>
        public MainView()
        {
            InitializeComponent();
        }

        #endregion

        #region Properties

        /// <summary>
        /// Gets or sets the original location textbox
        /// </summary>
        public string OriginalLocation
        {
            get
            {
                return txtOriginalLocation.Text;
            }

            set
            {
                txtOriginalLocation.Text = value;
            }
        }

        /// <summary>
        /// Gets or sets the destination location textbox
        /// </summary>
        public string DestinationLocation
        {
            get
            {
                return txtDestinationLocation.Text;
            }

            set
            {
                txtDestinationLocation.Text = value;
            }
        }

        /// <summary>
        /// Gets or sets the sortation schema title label
        /// </summary>
        public string SchemaTitle
        {
            get
            {
                return lblSchemaTitle.Text;
            }

            set
            {
                lblSchemaTitle.Text = value;
            }
        }

        #endregion

        #region Methods

        /// <summary>
        /// Set the main controller for the view
        /// </summary>
        /// <param name="mainController"> The main controller </param>
        public void SetController(IMainController mainController)
        {
            _mainController = mainController;
        }

        /// <summary>
        /// Displays an error message box
        /// </summary>
        /// <param name="message"> The error message </param>
        public void ErrorBox(string message)
        {
            MessageBox.Show(message, "Error");
        }

        #endregion

        #region Events

        /// <summary>
        /// The action for the original location folder browser
        /// </summary>
        /// <param name="sender"> The sender </param>
        /// <param name="e"> The event arguments </param>
        private void BtnOriginalLocationBrowse_Click(object sender, EventArgs e)
        {
            string path = _mainController.SelectFolder(OriginalLocation);
            txtOriginalLocation.Text = path;
        }

        /// <summary>
        /// The action for the destination location folder browser
        /// </summary>
        /// <param name="sender"> The sender </param>
        /// <param name="e"> The event arguments </param>
        private void BtnDestinationLocationBrowse_Click(object sender, EventArgs e)
        {
            string path = _mainController.SelectFolder(DestinationLocation);
            txtOriginalLocation.Text = path;
        }

        /// <summary>
        /// The action to create a sortation schema
        /// </summary>
        /// <param name="sender"> The sender </param>
        /// <param name="e"> The event arguments </param>
        private void BtnCreateSchema_Click(object sender, EventArgs e)
        {
            _mainController.CreateSchema();
        }

        /// <summary>
        /// The action to edit the sortation schema
        /// </summary>
        /// <param name="sender"> The sender </param>
        /// <param name="e"> The event arguments </param>
        private void BtnEditSchema_Click(object sender, EventArgs e)
        {
            _mainController.EditSchema();
        }

        /// <summary>
        /// The action to kick off sorting
        /// </summary>
        /// <param name="sender"> The sender </param>
        /// <param name="e"> The event arguments </param>
        private void BtnStartSort_Click(object sender, EventArgs e)
        {
            _mainController.SortWithoutDiagnostics();
        }

        /// <summary>
        /// The action to load sortation schema
        /// </summary>
        /// <param name="sender"> The sender </param>
        /// <param name="e"> The event arguments </param>
        private void LoadSchema_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Feature not implemented");
        }

        #endregion
    }
}
