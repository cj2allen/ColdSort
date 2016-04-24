﻿using ColdSort.Core.Interfaces.Models;
using ColdSort.Core.Interfaces.Controllers;
using ColdSort.UI.Forms;
using ColdSort.Core.Enums;

namespace ColdSort.Controller.Controllers
{
    internal class SortationNodeController : ISortationNodeController
    {
        private SortationNodeView _sortationNodeView;
        private ISortationNode _sortationNode;

        public SortationNodeController(SortationNodeView sortationNodeView, ISortationNode sortationNode)
        {
            _sortationNodeView = sortationNodeView;
            _sortationNodeView.SetController(this);
            _sortationNode = sortationNode;
        }

        public void LoadView()
        {
            _sortationNodeView.NodeName = _sortationNode.Name;
            _sortationNodeView.SongProperties = (int)_sortationNode.SongProperty;
            _sortationNodeView.AllowSortEnd = _sortationNode.AllowSortEnd;
            _sortationNodeView.UseAbbreviation = _sortationNode.UseAbbreviation;
        }

        public void Save()
        {
            _sortationNode.Name = _sortationNodeView.NodeName;
            _sortationNode.SongProperty = (SongProperty) _sortationNodeView.SongProperties;
            _sortationNode.AllowSortEnd = _sortationNodeView.AllowSortEnd;
            _sortationNode.UseAbbreviation = _sortationNodeView.UseAbbreviation;
            UnloadView();
        }

        public void Cancel()
        {
            UnloadView();
        }

        public ISortationNode GetSortationNode()
        { 
            return _sortationNode;
        }

        public void UnloadView()
        {
            _sortationNodeView.Hide();
        }
    }
}