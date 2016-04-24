using ColdSort.Core.Interfaces.Models;
using System.Collections.Generic;

namespace ColdSort.Core.Interfaces.Controllers
{
    public interface ISortationSchemaController
    {
        void LoadSchemaData(ISortationSchema sortationSchema);

        List<ISortationNode> RaiseNode(int index);

        List<ISortationNode> LowerNode(int index);

        List<ISortationNode> RemoveNode(int index);

        List<ISortationNode> CreateSortationNode();

        List<ISortationNode> EditSortationNode(int index);

        ISortationSchema GetSortationSchema();
    }
}