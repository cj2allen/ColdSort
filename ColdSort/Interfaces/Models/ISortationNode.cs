using ColdSort.Core.Enums;

namespace ColdSort.Core.Interfaces.Models
{
    public interface ISortationNode
    {
        string Name { get; set; }
        SongProperty SongProperty { get; set; }
        bool AllowSortEnd { get; set; }
        bool UseAbbreviation { get; set; }
        string GetSortationNodeProperty();
        SortationNodeResult Evaluate(ISongFile songFile, ref string newDirectory);
        string ToString();
    }
}