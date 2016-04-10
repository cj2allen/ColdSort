namespace ColdSort.Core.Interfaces.Models
{
    public interface ISortationResult
    {
        string OriginalPath { get; set; }
        string SortedPath { get; set; }
        bool IsSorted { get; set; }
        string ErrorMessage { get; set; }
    }
}
