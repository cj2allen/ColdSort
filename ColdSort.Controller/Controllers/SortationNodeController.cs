using ColdSort.Model.Models;
using ColdSort.Core.Interfaces.Models;
using ColdSort.Core.Interfaces.Controllers;
using ColdSort.Core.Interfaces.Views;

namespace ColdSort.Controller.Controllers
{
    internal class SortationNodeController : ISortationNodeController
    {
        private ISortationNodeView _sortationNodeView;
        private ISortationNode _sortationNode;

        public SortationNodeController(ISortationNodeView sortationNodeView, ISortationNode sortationNode)
        {
            _sortationNodeView = sortationNodeView;
            _sortationNodeView.SetController(this);
        }

        public void LoadView()
        {
            _sortationNodeView.NodeName = _sortationNode.Name;
            _sortationNodeView.Property = (int)_sortationNode.SongProperty;
            _sortationNodeView.AllowSortEnd = _sortationNode.AllowSortEnd;
            _sortationNodeView.UseAbbreviation = _sortationNode.UseAbbreviation;
        }

        public void Save()
        {
            UnloadView();
        }

        public void Cancel()
        {
            _sortationNode = null;
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