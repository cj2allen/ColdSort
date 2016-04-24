using ColdSort.Core.Interfaces.Controllers;
using ColdSort.Core.Interfaces.Views;
using System;
using System.Windows.Forms;

namespace ColdSort.UI.Forms
{
    public partial class SortationNodeView : Form, ISortationNodeView
    {
        private ISortationNodeController _sortationNodeController;

        public string NodeName
        {
            get
            {
                return txtNodeName.Text;
            }
            set
            {
                txtNodeName.Text = value;
            }
        }
        
        public int Property
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
    }
}
