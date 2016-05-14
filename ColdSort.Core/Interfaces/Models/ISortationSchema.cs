using System.Collections.Generic;

namespace ColdSort.Core.Interfaces.Models
{
    public interface ISortationSchema
    {
        string SortationSchemaTitle { get; set; }
        string FailedSortationDefault { get; set; }
        List<ISortationNode> SortationNodes { get; set; }
        bool KeepFilesAtOriginalLocation { get; set; }
        List<ISortationSchemaResult> SortPathingResults { get; set; }
        string ToString();
    }
}