//-----------------------------------------------------------------------
// <copyright file="MainView.cs" company="None">
//     Copyright (c) 2016 Christopher James Allen
// </copyright>
// <author>Christopher James Allen</author>
//-----------------------------------------------------------------------

using System;
using System.Windows.Forms;
using ColdSort.Interfaces.Controllers;
using ColdSort.Services;

namespace ColdSort.Views
{
    /// <summary>
    /// The main view form
    /// </summary>
    public partial class MainView : Form
    {
        #region Members

        /// <summary>
        /// The main controller
        /// </summary>
        private IMainController _mainController;

        /// <summary>
        /// The main controller
        /// </summary>
        private SortationService _SortationService;

        #endregion

        #region Delegates

        /// <summary>
        /// Delegate for setting the progress bar
        /// </summary>
        /// <param name="percentage"> Current percentage </param>
        private delegate void SetProgressCountInvoke(int percentage);

        /// <summary>
        /// Delegate for setting the progress percentage
        /// </summary>
        /// <param name="percentage"> Current file count </param>
        private delegate void SetFileCountInvoke(int percentage);

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

        #region Methods

        /// <summary>
        /// Set the sortation controller for the view
        /// </summary>
        /// <param name="SortationService"> The sortation controller </param>
        public void SetController(SortationService SortationService)
        {
            _SortationService = SortationService;
        }

        /// <summary>
        /// Updates the progress bar and percentage text
        /// </summary>
        /// <param name="percentage"> The sortation controller </param>
        public void UpdateProgress(int percentage)
        {
            SetProgressBar(percentage);
            SetFileCount(percentage);
        }

        /// <summary>
        /// Button to cancel the sort
        /// </summary>
        /// <param name="sender"> The sender </param>
        /// <param name="e"> The event arguments </param>
        private void BtnCancel_Click(object sender, EventArgs e)
        {
            _SortationService.CancelSort();
        }

        /// <summary>
        /// Updates the progress bar
        /// </summary>
        /// <param name="percentage"> The sortation controller </param>
        private void SetProgressBar(int percentage)
        {
            if (percentage > 0)
            {
                if (this.pbSortProgress.InvokeRequired)
                {
                    SetProgressCountInvoke inv = new SetProgressCountInvoke(SetProgressBar);
                    this.BeginInvoke(inv, new object[] { percentage });
                }
                else
                {
                    pbSortProgress.Value = percentage;
                    this.Refresh();
                }
            }
        }

        /// <summary>
        /// Updates the percentage text
        /// </summary>
        /// <param name="percentage"> The sortation controller </param>
        private void SetFileCount(int percentage)
        {
            if (this.pbSortProgress.InvokeRequired)
            {
                SetFileCountInvoke inv = new SetFileCountInvoke(SetFileCount);
                this.BeginInvoke(inv, new object[] { percentage });
            }
            else
            {
                lblAction.Text = string.Format("{0}%", percentage);
                this.Refresh();
            }
        }

        #endregion

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
            lblAction.Text = "Loading...";
            btnCancel.Enabled = true;
            _mainController.SortWithoutDiagnostics();
            btnCancel.Enabled = false;
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

        /// <summary>
        /// The close action
        /// </summary>
        /// <param name="sender"> The sender </param>
        /// <param name="e"> The event arguments </param>
        private void MainView_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        #endregion
    }
}
