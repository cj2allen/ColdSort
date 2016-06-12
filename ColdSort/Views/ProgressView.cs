using ColdSort.Core.Interfaces.Controllers;
using System;
using System.ComponentModel;
using System.Threading;
using System.Windows.Forms;
using ColdSort.Controllers;

namespace ColdSort.Views
{
    public partial class ProgressView : Form
    {
        #region Internal variables

        SortationController _sortationController;
        private delegate void SetProgressCountInvoke(int currentFileCount);
        private delegate void SetFileCountInvoke(int setFileCount);

        #endregion

        #region Methods

        public void SetController(SortationController sortationController)
        {
            _sortationController = sortationController;
        }

        public ProgressView()
        {
            InitializeComponent();
        }
        
        private void btnCancel_Click(object sender, EventArgs e)
        {
            _sortationController.CancelSort();
        }

        public void UpdateProgress(int percentage)
        {
            SetProgressBar(percentage);
            SetFileCount(percentage);
        }

        #endregion

        #region Invoke Methods

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

        public void SetFileCount(int percentage)
        {
            if (this.pbSortProgress.InvokeRequired)
            {
                SetFileCountInvoke inv = new SetFileCountInvoke(SetFileCount);
                this.BeginInvoke(inv, new object[] { percentage });
            }
            else
            {
                lblAction.Text = String.Format("{0}%", percentage);
                this.Refresh();
            }
        }

        #endregion
    }
}
