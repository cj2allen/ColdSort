using ColdSort.Core.Interfaces.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColdSort.UI.Forms
{
    public partial class ProgressView : Form
    {
        private int _numOfFiles;
        private int _currentFileCount;


        public ProgressView(int numberOfFiles)
        {
            InitializeComponent();
            _numOfFiles = numberOfFiles;

            pbSortProgress.Minimum = 0;            
            pbSortProgress.Maximum = _numOfFiles;
            pbSortProgress.Value = 0;
            pbSortProgress.Step = 1;
        }

        public void Update(string songFile)
        {
            _currentFileCount++;
            lblAction.Text = String.Format("Sorting %s", songFile);
            lblProgressCount.Text = String.Format("%d//%d", _currentFileCount, _numOfFiles);
            pbSortProgress.PerformStep();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            throw new CancelSortException();
        }
    }

    public class CancelSortException : Exception
    {
    }
}
