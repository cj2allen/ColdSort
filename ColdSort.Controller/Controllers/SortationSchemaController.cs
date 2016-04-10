using ColdSort.Core.Interfaces.Controllers;
using ColdSort.Core.Interfaces.Models;
using ColdSort.Core.Interfaces.Views;
using ColdSort.Model.Models;
using ColdSort.UI.Forms;
using System.Collections.Generic;
using System.Linq;

namespace ColdSort.Controller.Controllers
{
    public class SortationSchemaController : ISortationSchemaController
    {
        private ISortationSchemaView _sortationSchemaView;
        private ISortationSchema _sortationSchema;

        public SortationSchemaController(ISortationSchemaView sortationSchemaController)
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
            ISortationNodeView sortationNodeView = new SortationNodeView();
            sortationNodeView.Visible = false;
            //TODO lock sortation schema window

            ISortationNodeController sortationNodeController = new SortationNodeController(sortationNodeView, _sortationSchema.SortationNodes[index]);
            sortationNodeController.LoadView();
            ISortationNode node = sortationNodeController.GetSortationNode();

            if (node != null)
            {
                _sortationSchema.SortationNodes[index] = node;
            }
            else
            {
                _sortationSchema.SortationNodes.RemoveAt(index);
            }

            return _sortationSchema.SortationNodes;
        }

        public ISortationSchema GetSortationSchema()
        {
            return _sortationSchema;
        }
    }
}
