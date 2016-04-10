using ColdSort.Core.Interfaces.Models;

namespace ColdSort.Model.Models
{
    public class FailedSortation : ISortationSchemaResult
    {
        public string OriginalPath { get; set; }
        public string ErrorMessage { get; set; }
    }
}
