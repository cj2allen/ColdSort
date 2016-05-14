using ColdSort.Core.Interfaces.Controllers;
using ColdSort.Core.Interfaces.Models;
using ColdSort.Views;
using ColdSort.Models;
using System.Collections.Generic;
using System.Linq;

namespace ColdSort.Controllers
{
    public class SortationSchemaController : ISortationSchemaController
    {
        private SortationSchemaView _sortationSchemaView;
        private ISortationSchema _sortationSchema;

        public SortationSchemaController(SortationSchemaView sortationSchemaController)
        {
            _sortationSchemaView = sortationSchemaController;
            _sortationSchemaView.SetController(this);
        }

        public void LoadSchemaData (ISortationSchema sortationSchema)
        {
            _sortationSchema = sortationSchema;
            _sortationSchemaView.SchemaName = _sortationSchema.SortationSchemaTitle;
            _sortationSchemaView.FailedDefaultLocation = _sortationSchema.FailedSortationDefault;
            _sortationSchemaView.KeepFilesAtOriginalLocation = _sortationSchema.KeepFilesAtOriginalLocation;
            _sortationSchemaView.UseFailedDefaultLocation = !_sortationSchema.KeepFilesAtOriginalLocation;
            _sortationSchemaView.SortationNodes = _sortationSchema.SortationNodes;
            _sortationSchemaView.ShowDialog();
        }

        public List<ISortationNode> RaiseNode(int index)
        {
            ISortationNode node = _sortationSchema.SortationNodes[index];
            _sortationSchema.SortationNodes.RemoveAt(index);
            _sortationSchema.SortationNodes.Insert(index - 1, node);
            return _sortationSchema.SortationNodes;
        }

        public List<ISortationNode> LowerNode(int index)
        {
            ISortationNode node = _sortationSchema.SortationNodes[index];
            _sortationSchema.SortationNodes.RemoveAt(index);
            _sortationSchema.SortationNodes.Insert(index + 1, node);
            return _sortationSchema.SortationNodes;
        }

        public List<ISortationNode> RemoveNode(int index)
        {
            _sortationSchema.SortationNodes.RemoveAt(index);
            return _sortationSchema.SortationNodes;
        }

        public List<ISortationNode> CreateSortationNode()
        {
            _sortationSchema.SortationNodes.Add(new SortationNode());                 
            return EditSortationNode(_sortationSchema.SortationNodes.Count()-1);

        }
        
        public List<ISortationNode> EditSortationNode(int index)
        {
            using (SortationNodeView sortationNodeView = new SortationNodeView())
            {
                ISortationNodeController sortationNodeController = new SortationNodeController(sortationNodeView, _sortationSchema.SortationNodes[index]);                
                sortationNodeView.Visible = false;
                sortationNodeController.LoadView();
                sortationNodeView.ShowDialog();
                ISortationNode node = sortationNodeController.GetSortationNode();
                _sortationSchema.SortationNodes[index] = node;
            }

            return _sortationSchema.SortationNodes;
        }

        public ISortationSchema SortationSchema
        {
            get
            {
                return _sortationSchema;
            }
        }

        public void SaveSchema()
        {
            _sortationSchema.SortationSchemaTitle = _sortationSchemaView.SchemaName;
            _sortationSchema.FailedSortationDefault = _sortationSchemaView.FailedDefaultLocation;
            _sortationSchema.KeepFilesAtOriginalLocation = _sortationSchemaView.KeepFilesAtOriginalLocation;
            _sortationSchema.SortationNodes = _sortationSchemaView.SortationNodes;
            UnloadView();
        }

        public void CancelSchema()
        {
            UnloadView();
        }

        public void UnloadView()
        {
            _sortationSchemaView.Hide();
        }

        public ISortationSchema GetSortationSchema()
        {
            return _sortationSchema;
        }
    }
}
