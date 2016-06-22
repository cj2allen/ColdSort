//-----------------------------------------------------------------------
// <copyright file="SortationSchemaController.cs" company="None">
//     Copyright (c) 2016 Christopher James Allen
// </copyright>
// <author>Christopher James Allen</author>
//-----------------------------------------------------------------------

using System.Collections.Generic;
using System.Linq;
using ColdSort.Core.Interfaces.Controllers;
using ColdSort.Core.Interfaces.Models;
using ColdSort.Models;
using ColdSort.Views;

namespace ColdSort.Controllers
{
    /// <summary>
    /// Manage sortation schema view functionality
    /// </summary>
    public class SortationSchemaController : ISortationSchemaController
    {
        #region Fields

        /// <summary>
        /// The sortation schema view form
        /// </summary>
        private SortationSchemaView _sortationSchemaView;

        /// <summary>
        /// The current sortation schema
        /// </summary>
        private ISortationSchema _sortationSchema;

        #endregion

        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="SortationSchemaController"/> class
        /// </summary>
        /// <param name="sortationSchemaView"> The sortation schema view form </param>
        /// <param name="sortationSchema"> The current sortation schema </param>
        public SortationSchemaController(SortationSchemaView sortationSchemaView, ISortationSchema sortationSchema)
        {
            _sortationSchema = sortationSchema;
            _sortationSchemaView = sortationSchemaView;
            _sortationSchemaView.SetController(this);
        }

        #endregion

        #region Methods

        /// <summary>
        /// Load the sortation schema view with data
        /// </summary>
        public void SetupView()
        {
            _sortationSchemaView.SchemaName = _sortationSchema.SortationSchemaTitle;
            _sortationSchemaView.FailedDefaultLocation = _sortationSchema.FailedSortationDefault;
            _sortationSchemaView.KeepFilesAtOriginalLocation = _sortationSchema.KeepFilesAtOriginalLocation;
            _sortationSchemaView.UseFailedDefaultLocation = !_sortationSchema.KeepFilesAtOriginalLocation;
            _sortationSchemaView.SortationNodes = _sortationSchema.SortationNodes;
            _sortationSchemaView.ShowDialog();
        }

        /// <summary>
        /// Raises the node at the selected index up an element
        /// </summary>
        /// <param name="index"> The current position of the element that is to be raised </param>
        /// <returns> A list of the updated position of sortation nodes</returns>
        public List<ISortationNode> RaiseNode(int index)
        {
            ISortationNode node = _sortationSchema.SortationNodes[index];
            _sortationSchema.SortationNodes.RemoveAt(index);
            _sortationSchema.SortationNodes.Insert(index - 1, node);
            return _sortationSchema.SortationNodes;
        }

        /// <summary>
        /// Lower the node sortation at the selected index down an element
        /// </summary>
        /// <param name="index"> The current position of the element that is to be lowered </param>
        /// <returns> A list of the updated position of sortation nodes</returns>
        public List<ISortationNode> LowerNode(int index)
        {
            ISortationNode node = _sortationSchema.SortationNodes[index];
            _sortationSchema.SortationNodes.RemoveAt(index);
            _sortationSchema.SortationNodes.Insert(index + 1, node);
            return _sortationSchema.SortationNodes;
        }

        /// <summary>
        /// Removes the sortation node at the selected index
        /// </summary>
        /// <param name="index"> The current position of the element that is to be removed </param>
        /// <returns> An updated list of sortation nodes</returns>
        public List<ISortationNode> RemoveNode(int index)
        {
            _sortationSchema.SortationNodes.RemoveAt(index);
            return _sortationSchema.SortationNodes;
        }

        /// <summary>
        /// Adds a sortation node to a sortation schema
        /// </summary>        
        /// <returns> An updated list of sortation nodes</returns>
        public List<ISortationNode> CreateSortationNode()
        {
            _sortationSchema.SortationNodes.Add(new SortationNode());
            return EditSortationNode(_sortationSchema.SortationNodes.Count() - 1);
        }

        /// <summary>
        /// Edits the sortation node at the selected index
        /// </summary>
        /// <param name="index"> The current position of the element that is to be edited </param>
        /// <returns> An updated list of sortation nodes</returns>
        public List<ISortationNode> EditSortationNode(int index)
        {
            using (SortationNodeView sortationNodeView = new SortationNodeView())
            {
                ISortationNodeController sortationNodeController = new SortationNodeController(sortationNodeView, _sortationSchema.SortationNodes[index]);
                sortationNodeView.Visible = false;
                sortationNodeController.SetupView();
                sortationNodeView.ShowDialog();
                ISortationNode node = sortationNodeController.GetSortationNode();
                _sortationSchema.SortationNodes[index] = node;
            }

            return _sortationSchema.SortationNodes;
        }

        /// <summary>
        /// Updates the sortation schema with the current data
        /// </summary>
        public void SaveSchema()
        {
            if (string.IsNullOrEmpty(_sortationSchemaView.SchemaName))
            {
                _sortationSchemaView.ErrorBox("Your Sortation Schema needs to have a name.");
            }
            else if (_sortationSchema.SortationNodes.Count <= 0)
            {
                _sortationSchemaView.ErrorBox("Your Sortation Schema needs to have at least one Sortation Node");
            }
            else if (_sortationSchemaView.UseFailedDefaultLocation && string.IsNullOrEmpty(_sortationSchemaView.FailedDefaultLocation))
            {
                _sortationSchemaView.ErrorBox("Your default directory for unsortable songs cannot be empty.");
            }
            else
            {
                _sortationSchema.SortationSchemaTitle = _sortationSchemaView.SchemaName;
                _sortationSchema.KeepFilesAtOriginalLocation = _sortationSchemaView.KeepFilesAtOriginalLocation;
                _sortationSchema.SortationNodes = _sortationSchemaView.SortationNodes;

                if (_sortationSchemaView.UseFailedDefaultLocation)
                {
                    _sortationSchema.FailedSortationDefault = _sortationSchemaView.FailedDefaultLocation;
                }

                UnloadView();
            }
        }

        /// <summary>
        /// Keep original settings and discard changes
        /// </summary>
        public void CancelSchema()
        {
            UnloadView();
        }

        /// <summary>
        /// Returns the current sortation schema
        /// </summary>
        /// <returns> The sortation node </returns>
        public ISortationSchema GetSortationSchema()
        {
            return _sortationSchema;
        }

        /// <summary>
        /// Keep original settings and discard changes
        /// </summary>
        public void UnloadView()
        {
            _sortationSchemaView.Hide();
        }

        #endregion
    }
}
