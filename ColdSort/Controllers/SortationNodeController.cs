﻿//-----------------------------------------------------------------------
// <copyright file="SortationNodeController.cs" company="None">
//     Copyright (c) 2016 Christopher James Allen
// </copyright>
// <author>Christopher James Allen</author>
//-----------------------------------------------------------------------

using ColdSort.Enums;
using ColdSort.Interfaces.Controllers;
using ColdSort.Models;
using ColdSort.Views;

namespace ColdSort.Services
{
    /// <summary>
    /// Manages sortation node view functionality 
    /// </summary>
    public class SortationNodeController : ISortationNodeController
    {
        #region Fields

        /// <summary>
        /// The sortation node view form
        /// </summary>
        private SortationNodeView _sortationNodeView;

        /// <summary>
        /// The current sortation node being used
        /// </summary>
        private SortationNode _sortationNode;

        #endregion

        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="SortationNodeController"/> class
        /// </summary>
        /// <param name="sortationNodeView"> The sortation node view form </param>
        /// <param name="sortationNode"> The current sortation node </param>
        public SortationNodeController(SortationNodeView sortationNodeView, SortationNode sortationNode)
        {
            _sortationNodeView = sortationNodeView;
            _sortationNodeView.SetController(this);
            _sortationNode = sortationNode;
        }

        #endregion

        #region Methods

        /// <summary>
        /// The current sortation node being used
        /// </summary>
        public void SetupView()
        {
            _sortationNodeView.SongProperties = (int)_sortationNode.SongProperty;
            _sortationNodeView.AllowSortEnd = _sortationNode.AllowSortEnd;
            _sortationNodeView.UseAbbreviation = _sortationNode.UseAbbreviation;
            _sortationNodeView.CondenseNumbersToSymbol = _sortationNode.CondenseNumbersToSymbol;
            _sortationNodeView.CapitalizeAbbreviation = _sortationNode.CapitalizeAbbreviation;
            _sortationNodeView.CondenseAccents = _sortationNode.CondenseAccents;
            _sortationNodeView.CondenseSymbols = _sortationNode.CondenseSymbols;
        }

        /// <summary>
        /// Update settings to current settings
        /// </summary>
        public void Confirm()
        {
            _sortationNode.SongProperty = (SongProperty)_sortationNodeView.SongProperties;
            _sortationNode.AllowSortEnd = _sortationNodeView.AllowSortEnd;
            _sortationNode.UseAbbreviation = _sortationNodeView.UseAbbreviation;
            UnloadView();
        }

        /// <summary>
        /// Keep original settings and discard changes
        /// </summary>
        public void Cancel()
        {
            UnloadView();
        }

        /// <summary>
        /// Returns the current sortation node
        /// </summary>
        /// <returns> The sortation node </returns>
        public SortationNode GetSortationNode()
        {
            return _sortationNode;
        }

        /// <summary>
        /// Cleans up view
        /// </summary>
        public void UnloadView()
        {
            _sortationNodeView.Hide();
        }

        #endregion
    }
}