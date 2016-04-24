using ColdSort.Core.Interfaces.Models;
using System;
using System.Collections.Generic;

namespace ColdSort.Model.Models
{
    public class SortationSchema : ISortationSchema
    {
        public string SortationSchemaTitle { get; set; }
        public string FailedSortationDefault { get; set; }
        public List<ISortationNode> SortationNodes { get; set; }
        public bool KeepFilesAtOriginalLocation { get; set; }
        public List<ISortationSchemaResult> SortPathingResults { get; set; }

        public override String ToString()
        {
            return SortationSchemaTitle;
        }
    }
}
