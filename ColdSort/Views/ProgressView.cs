//-----------------------------------------------------------------------
// <copyright file="ProgressView.cs" company="None">
//     Copyright (c) 2016 Christopher James Allen
// </copyright>
// <author>Christopher James Allen</author>
//-----------------------------------------------------------------------

using System;
using System.Windows.Forms;
using ColdSort.Controllers;

namespace ColdSort.Views
{
    /// <summary>
    /// The progress view form
    /// </summary>
    public partial class ProgressView : Form
    {
        #region Fields

        /// <summary>
        /// The sortation controller
        /// </summary>
        private SortationController _sortationController;

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="ProgressView"/> class
        /// </summary>
        public ProgressView()
        {
            InitializeComponent();
        }

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

        #region Methods

        /// <summary>
        /// Set the sortation controller for the view
        /// </summary>
        /// <param name="sortationController"> The sortation controller </param>
        public void SetController(SortationController sortationController)
        {
            _sortationController = sortationController;
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
            _sortationController.CancelSort();
        }

        /// <summary>
        /// Updates the progress bar
        /// </summary>
        /// <param name="percentage"> The sortation controller </param>
        private void SetProgressBar(int percentage)
        {
            if (percentage > 0)
            {
                if (this.lblProgressCount.InvokeRequired)
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
    }
}
