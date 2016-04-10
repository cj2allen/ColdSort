using System;
using ColdSort.Core.Interfaces.Models;

namespace ColdSort.Model.Models
{
    public class SortationResult : ISortationResult
    {
        public string ErrorMessage { get; set; }

        public bool IsSorted { get; set; }

        public string OriginalPath { get; set; }

        public string SortedPath { get; set; }
    }
}
