using ColdSort.Core.Enums;
using ColdSort.Core.Interfaces.Controllers;
using System;
using System.Windows.Forms;

namespace ColdSort.Views
{
    public partial class SortationNodeView : Form
    {
        private ISortationNodeController _sortationNodeController;

        public int SongProperties
        {
            get
            {
                return cbxSelectProperty.SelectedIndex;
            }
            set
            {
                cbxSelectProperty.SelectedIndex = value;
            }
        }

        public bool AllowSortEnd
        {
            get
            {
                return chkAllowSortEnd.Checked;
            }
            set
            {
                chkAllowSortEnd.Checked = value;
            }
        }

        public bool UseAbbreviation
        {
            get
            {
                return chkAbbreviateProperty.Checked;
            }
            set
            {
                chkAbbreviateProperty.Checked = value;
            }
        }
        public SortationNodeView()
        {
            InitializeComponent();
            cbxSelectProperty.DataSource = Enum.GetNames(typeof(SongProperty));
        }

        public void SetController(ISortationNodeController sortationNodeController)
        {
            _sortationNodeController = sortationNodeController;
        }

        private void btnSaveNode_Click(object sender, EventArgs e)
        {
            _sortationNodeController.Save();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            _sortationNodeController.Cancel();
        }

        private void SortationNodeView_FormClosing(object sender, FormClosingEventArgs e)
        {
            _sortationNodeController.Cancel();
        }
    }
}
