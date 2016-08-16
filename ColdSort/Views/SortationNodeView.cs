//-----------------------------------------------------------------------
// <copyright file="SortationNodeView.cs" company="None">
//     Copyright (c) 2016 Christopher James Allen
// </copyright>
// <author>Christopher James Allen</author>
//-----------------------------------------------------------------------

using System;
using System.Windows.Forms;
using ColdSort.Core.Enums;
using ColdSort.Core.Interfaces.Controllers;

namespace ColdSort.Views
{
    /// <summary>
    /// The sortation node view form
    /// </summary>
    public partial class SortationNodeView : Form
    {
        #region Fields

        /// <summary>
        /// The sortation node controller
        /// </summary>
        private ISortationNodeController _sortationNodeController;

        #endregion

        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="SortationNodeView"/> class
        /// </summary>
        public SortationNodeView()
        {
            InitializeComponent();
            cbxSelectProperty.DataSource = Enum.GetNames(typeof(SongProperty));
        }

        #endregion

        #region Properties

        /// <summary>
        /// Gets or sets the property the sortation node sorts on
        /// </summary>
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

        /// <summary>
        /// Gets or sets a value indicating whether sortation ends at this sortation node
        /// </summary>
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

        /// <summary>
        /// Gets or sets a value indicating whether sortation node abbreviates the folder it creates
        /// </summary>
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

        /// <summary>
        /// Gets or sets a value indicating whether to condense all number abbreviations into the folder #
        /// </summary>
        public bool CondenseNumbersToSymbol
        {
            get
            {
                return chkCondenseNumbers.Checked;
            }

            set
            {
                chkCondenseNumbers.Checked = value;
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether to capitalize all abbreviations
        /// </summary>
        public bool CapitalizeAbbreviation
        {
            get
            {
                return chkCaptitalizeAbbreviation.Checked;
            }

            set
            {
                chkCaptitalizeAbbreviation.Checked = value;
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether to capitalize all abbreviations
        /// </summary>
        public bool CondenseAccents
        {
            get
            {
                return chkCondenseAccents.Checked;
            }

            set
            {
                chkCondenseAccents.Checked = value;
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether to capitalize all abbreviations
        /// </summary>
        public bool CondenseSymbols
        {
            get
            {
                return chkCondenseSymbols.Checked;
            }

            set
            {
                chkCondenseSymbols.Checked = value;
            }
        }

        #endregion

        #region Methods

        /// <summary>
        /// Set the sortation node controller for the view
        /// </summary>
        /// <param name="sortationNodeController"> The main controller </param>
        public void SetController(ISortationNodeController sortationNodeController)
        {
            _sortationNodeController = sortationNodeController;
        }

        /// <summary>
        /// The button for updating the sortation node
        /// </summary>
        /// <param name="sender"> The sender </param>
        /// <param name="e"> The event arguments </param>
        private void BtnConfirmNode_Click(object sender, EventArgs e)
        {
            _sortationNodeController.Confirm();
        }

        /// <summary>
        /// The button for canceling the sortation node update
        /// </summary>
        /// <param name="sender"> The sender </param>
        /// <param name="e"> The event arguments </param>
        private void BtnCancel_Click(object sender, EventArgs e)
        {
            _sortationNodeController.Cancel();
        }

        
        private void SortationNodeView_FormClosing(object sender, FormClosingEventArgs e)
        {
            _sortationNodeController.Cancel();
        }
        
        /// <summary>
        /// Enable or disable abbreviation options
        /// </summary>
        /// <param name="sender"> The sender </param>
        /// <param name="e"> The event arguments </param>
        private void chkAbbreviateProperty_CheckedChanged(object sender, EventArgs e)
        {
            bool enable = chkAbbreviateProperty.Checked;
            chkCondenseNumbers.Enabled = enable;
            chkCaptitalizeAbbreviation.Enabled = enable;
            chkCondenseAccents.Enabled = enable;
            chkCondenseSymbols.Enabled = enable;
        }

        #endregion
    }
}
