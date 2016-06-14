using ColdSort.Core.Enums;

namespace ColdSort.Core.Interfaces.Models
{
    public interface ISortationNode
    {
        string Name { get; }
        SongProperty SongProperty { get; set; }
        bool AllowSortEnd { get; set; }
        bool UseAbbreviation { get; set; }
        string GetSortationNodeProperty();
        string ToString();
    }
}