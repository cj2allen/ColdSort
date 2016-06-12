using ColdSort.Core.Interfaces.Models;
using System;
using System.Collections.Generic;

namespace ColdSort.Models
{
    public class SortationSchema : ISortationSchema
    {
        public string SortationSchemaTitle { get; set; }
        public string FailedSortationDefault { get; set; }
        public List<ISortationNode> SortationNodes { get; set; }
        public bool KeepFilesAtOriginalLocation { get; set; }

        public SortationSchema ()
        {
            SortationNodes = new List<ISortationNode>();

        }

        public override String ToString()
        {
            return SortationSchemaTitle;
        }
    }
}
