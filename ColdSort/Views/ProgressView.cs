using ColdSort.Core.Interfaces.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColdSort.Views
{
    public partial class ProgressView : Form
    {
        private delegate void SetActionInvoke();
        private delegate void SetProgressCountInvoke();
        private delegate void SetProgressInvoke();
        private delegate void SetProgressBarInvoke(int setFileCount);

        private int _numberOfFiles;
        private int _currentFileCount;
        private string _songFile = "";
        
        public ProgressView()
        {
            InitializeComponent();
        }

        public void UpdateInfo(string songFile)
        {
            _songFile = songFile;
            _currentFileCount++;            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            backgroundWorker.CancelAsync();
            this.Hide();
        }

        private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            this.TopMost = true;
            this.Show();

            while(_currentFileCount < _numberOfFiles)
            {
                if (backgroundWorker.CancellationPending)
                {
                    throw new CancelSortException();
                }

                UpdateProgress();
                Thread.Sleep(10);
            }

            this.Hide();
        }

        private void UpdateProgress()
        {
            SetAction();
            SetProgressCount();
            SetProgress();
        }

        public void SetFileCount(int numberOfFiles)
        {
            if (this.pbSortProgress.InvokeRequired)
            {
                SetProgressBarInvoke inv = new SetProgressBarInvoke(SetFileCount);
                this.BeginInvoke(inv, new object[] { numberOfFiles });
            }
            else
            {
                _numberOfFiles = numberOfFiles;
                pbSortProgress.Maximum = _numberOfFiles;
                pbSortProgress.Value = 0;
                pbSortProgress.Step = 1;
                backgroundWorker.RunWorkerAsync();
            }
        }

        private void SetAction()
        {
            if (this.lblAction.InvokeRequired)
            {
                SetActionInvoke inv = new SetActionInvoke(SetAction);
                this.BeginInvoke(inv, new object[] { });
            }
            else
            {
                if (_currentFileCount > 0)
                {
                    lblAction.Text = _songFile;
                }
                else
                {
                    lblAction.Text = "Gather song files...";
                }

                this.Refresh();
            }
        }

        private void SetProgressCount()
        {
            if (_currentFileCount > 0)
            {
                if (this.lblProgressCount.InvokeRequired)
                {
                    SetProgressCountInvoke inv = new SetProgressCountInvoke(SetProgressCount);
                    this.BeginInvoke(inv);
                }
                else
                {
                    lblProgressCount.Text = String.Format("{0}/{1}", _currentFileCount, _numberOfFiles);
                    this.Refresh();
                }
            }
        }

        private void SetProgress()
        {
            if (_currentFileCount > 0)
            {
                if (this.lblProgressCount.InvokeRequired)
                {
                    SetProgressCountInvoke inv = new SetProgressCountInvoke(SetProgress);
                    this.BeginInvoke(inv);
                }
                else
                {
                    pbSortProgress.Value = _currentFileCount;
                    this.Refresh();
                }
            }
        }

        private void backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            this.Hide();
            MessageBox.Show("here");
        }
    }

    public class CancelSortException : Exception
    {
    }
}
