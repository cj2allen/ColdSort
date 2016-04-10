using ColdSort.Core.Interfaces.Models;

namespace ColdSort.Model.Models
{
    public class SuccessfulSortation : ISortationSchemaResult
    {
        public string OriginalPath { get; set; }
        public string SortedPath { get; set; }
    }
}