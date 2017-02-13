//-----------------------------------------------------------------------
// <copyright file="SortationSchemaView.cs" company="None">
//     Copyright (c) 2016 Christopher James Allen
// </copyright>
// <author>Christopher James Allen</author>
//-----------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ColdSort.Models;
using ColdSort.Services;

namespace ColdSort.Views
{
    /// <summary>
    /// The sortation schema view form
    /// </summary>
    public partial class SortationSchemaView : Form
    {
        #region Fields

        /// <summary>
        /// The sortation schema controller
        /// </summary>
        private SortationSchemaController _sortationSchemaController;

        #endregion

        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="SortationSchemaView"/> class
        /// </summary>
        public SortationSchemaView()
        {
            InitializeComponent();
        }

        #endregion

        #region Properties

        /// <summary>
        /// Gets or sets the schema name
        /// </summary>
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

        /// <summary>
        /// Gets or sets the failed default location for songs that fail to sort
        /// </summary>
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

        /// <summary>
        /// Gets or sets a value indicating whether to keep failed to sort song files at original location
        /// </summary>
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

        /// <summary>
        /// Gets or sets a value indicating whether to put failed to sort song files at default location
        /// </summary>
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

        /// <summary>
        /// Gets or sets a value indicating whether to copy song files instead of moving them
        /// </summary>
        public bool CopyFilesInsteadOfMoving
        {
            get
            {
                return cbCopyFiles.Checked;
            }

            set
            {
                cbCopyFiles.Checked = value;
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether to fix illegal characters in a path
        /// </summary>
        public bool FixIllegalCharacters
        {
            get
            {
                return chkFixIllegalCharacters.Checked;
            }

            set
            {
                chkFixIllegalCharacters.Checked = value;
            }
        }

        /// <summary>
        /// Gets or sets the list sortation nodes in the form
        /// </summary>
        public List<SortationNode> SortationNodes
        {
            get
            {
                List<SortationNode> sortationNodes = new List<SortationNode>();

                foreach (object sortationNode in lstSortationNodes.Items)
                {
                    sortationNodes.Add((SortationNode)sortationNode);
                }

                return sortationNodes;
            }

            set
            {
                lstSortationNodes.DataSource = null;
                lstSortationNodes.DataSource = value;
                lstSortationNodes.DisplayMember = "SortationNodeName";
            }
        }

        #endregion

        #region Methods

        /// <summary>
        /// Set the sortation schema controller for the view
        /// </summary>
        /// <param name="sortationSchemaController"> The sortation schema controller </param>
        public void SetController(SortationSchemaController sortationSchemaController)
        {
            _sortationSchemaController = sortationSchemaController;
        }

        /// <summary>
        /// Displays an error message box
        /// </summary>
        /// <param name="message"> The error message </param>
        public void ErrorBox(string message)
        {
            MessageBox.Show(message, "Error");
        }

        /// <summary>
        /// The action to raise a node in the list
        /// </summary>
        /// <param name="sender"> The sender </param>
        /// <param name="e"> The event arguments </param>
        private void BtnRaiseNode_Click(object sender, EventArgs e)
        {
            int index = lstSortationNodes.SelectedIndex;

            if (index > 0)
            {
                List<SortationNode> sortationNodes = _sortationSchemaController.RaiseNode(index);
                SortationNodes = sortationNodes;
                lstSortationNodes.SelectedIndex = index - 1;
            }
            else if (index < 0)
            {
                ErrorBox("No Sortation Node Selected.");
            }
        }

        /// <summary>
        /// The action to lower a node in the list
        /// </summary>
        /// <param name="sender"> The sender </param>
        /// <param name="e"> The event arguments </param>
        private void BtnLowerNode_Click(object sender, EventArgs e)
        {
            int index = lstSortationNodes.SelectedIndex;

            if (index < (lstSortationNodes.Items.Count - 1))
            {
                List<SortationNode> sortationNodes = _sortationSchemaController.LowerNode(index);
                SortationNodes = sortationNodes;
                lstSortationNodes.SelectedIndex = index + 1;
            }
            else if (index < 0)
            {
                ErrorBox("No Sortation Node Selected.");
            }
        }

        /// <summary>
        /// The action to delete a node from the list
        /// </summary>
        /// <param name="sender"> The sender </param>
        /// <param name="e"> The event arguments </param>
        private void BtnDeleteNode_Click(object sender, EventArgs e)
        {
            int index = lstSortationNodes.SelectedIndex;

            if (index > 0)
            {
                List<SortationNode> sortationNodes = _sortationSchemaController.LowerNode(index);
                SortationNodes = sortationNodes;
            }
            else
            {
                ErrorBox("No Sortation Node Selected.");
            }
        }

        /// <summary>
        /// The action to add a node to the list
        /// </summary>
        /// <param name="sender"> The sender </param>
        /// <param name="e"> The event arguments </param>
        private void BtnNewNode_Click(object sender, EventArgs e)
        {
            List<SortationNode> sortationNodes = _sortationSchemaController.CreateSortationNode();
            SortationNodes = sortationNodes;
        }

        /// <summary>
        /// The action to edit a node in the list
        /// </summary>
        /// <param name="sender"> The sender </param>
        /// <param name="e"> The event arguments </param>
        private void BtnEditNode_Click(object sender, EventArgs e)
        {
            int index = lstSortationNodes.SelectedIndex;

            if ((index >= 0) && index < SortationNodes.Count)
            {
                List<SortationNode> sortationNodes = _sortationSchemaController.EditSortationNode(index);
                SortationNodes = sortationNodes;
            }
            else
            {
                ErrorBox("No Sortation Node Selected.");
            }
        }

        /// <summary>
        /// The action when the window closes
        /// </summary>
        /// <param name="sender"> The sender </param>
        /// <param name="e"> The event arguments </param>
        private void SortationSchemaView_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("Saving not implemented. Created schema can still be used.");
            _sortationSchemaController.CancelSchema();
        }

        /// <summary>
        /// The action to confirm the schema updates
        /// </summary>
        /// <param name="sender"> The sender </param>
        /// <param name="e"> The event arguments </param>
        private void BtnConfirmSchema_Click(object sender, EventArgs e)
        {
            _sortationSchemaController.SaveSchema();
        }

        /// <summary>
        /// The action to cancel a sortation schema update
        /// </summary>
        /// <param name="sender"> The sender </param>
        /// <param name="e"> The event arguments </param>
        private void BtnCancelSchema_Click(object sender, EventArgs e)
        {
            _sortationSchemaController.CancelSchema();
        }

        /// <summary>
        /// The action to check the keep location radio button
        /// </summary>
        /// <param name="sender"> The sender </param>
        /// <param name="e"> The event arguments </param>
        private void RdoKeepLocation_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoKeepLocation.Checked)
            {
                txtFailedDefaultLocation.Enabled = false;
                txtFailedDefaultLocation.ReadOnly = true;
            }
        }

        /// <summary>
        /// The action to check the failed default location radio button
        /// </summary>
        /// <param name="sender"> The sender </param>
        /// <param name="e"> The event arguments </param>
        private void RdoFailedDefaultLocation_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoFailedDefaultLocation.Checked)
            {
                txtFailedDefaultLocation.Enabled = true;
                txtFailedDefaultLocation.ReadOnly = false;
            }
        }

        #endregion
    }
}
