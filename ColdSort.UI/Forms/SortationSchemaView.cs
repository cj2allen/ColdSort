﻿using ColdSort.Core.Interfaces.Controllers;
using ColdSort.Core.Interfaces.Models;
using ColdSort.Core.Interfaces.Views;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ColdSort.UI.Forms
{
    public partial class SortationSchemaView : Form, ISortationSchemaView
    {
        private ISortationSchemaController _sortationSchemaController;

        public string SchemaName
        {
            get
            {
                return txtSortationSchemaName.Text;
            }
            set
            {
                txtSortationSchemaName.Text = value;
            }
        }

        public string FailedDefaultLocation
        {
            get
            {
                return txtFailedDefaultLocation.Text;
            }
            set
            {
                txtFailedDefaultLocation.Text = value;
            }
        }

        public bool KeepFilesAtOriginalLocation
        {
            get
            {
                return rdoKeepLocation.Checked;
            }
            set
            {
                rdoKeepLocation.Checked = value;
            }
        }

        public bool UseFailedDefaultLocation
        {
            get
            {
                return rdoFailedDefaultLocation.Checked;
            }
            set
            {
                rdoFailedDefaultLocation.Checked = value;
            }
        }

        public List<ISortationNode> SortationNodes
        {
            get
            {
                List<ISortationNode> sortationNodes = new List<ISortationNode>();

                foreach (object sortationNode in lstSortationNodes.Items)
                {
                    sortationNodes.Add((ISortationNode)sortationNode);
                }

                return sortationNodes;
            }
            set
            {
                lstSortationNodes.DataSource = null;
                lstSortationNodes.DataSource = value;
            }
        }

        public SortationSchemaView()
        {
            InitializeComponent();
        }

        public void SetController(ISortationSchemaController sortationSchemaController)
        {
            _sortationSchemaController = sortationSchemaController;
        }

        public void ErrorBox(string message)
        {
            MessageBox.Show("Error", message);
        }

        private void btnRaiseNode_Click(object sender, EventArgs e)
        {
            int index = lstSortationNodes.SelectedIndex;

            if (index > 0)
            {
                List<ISortationNode> sortationNodes = _sortationSchemaController.RaiseNode(index);
                SortationNodes = sortationNodes;
            }
            else if (index < 0)
            {
                ErrorBox("No Sortation Node Selected.");
            }
        }

        private void btnLowerNode_Click(object sender, EventArgs e)
        {
            int index = lstSortationNodes.SelectedIndex;

            if (index > 0 && index > lstSortationNodes.Items.Count)
            {
                List<ISortationNode> sortationNodes = _sortationSchemaController.RemoveNode(index);
                SortationNodes = sortationNodes;
            }
            else if (index < 0)
            {
                ErrorBox("No Sortation Node Selected.");
            }
        }

        private void btnDeleteNode_Click(object sender, EventArgs e)
        {
            int index = lstSortationNodes.SelectedIndex;

            if (index > 0)
            {
                List<ISortationNode> sortationNodes = _sortationSchemaController.LowerNode(index);
                SortationNodes = sortationNodes;
            }
            else
            {
                ErrorBox("No Sortation Node Selected.");
            }
        }

        private void btnNewNode_Click(object sender, EventArgs e)
        {
            List<ISortationNode> sortationNodes = _sortationSchemaController.CreateSortationNode();
            SortationNodes = sortationNodes;
        }

        private void btnEditNode_Click(object sender, EventArgs e)
        {
            int index = lstSortationNodes.SelectedIndex;

            if (index > 0)
            {
                List<ISortationNode> sortationNodes = _sortationSchemaController.EditSortationNode(index);
                SortationNodes = sortationNodes;
            }
            else
            {
                ErrorBox("No Sortation Node Selected.");
            }
        }
    }
}
