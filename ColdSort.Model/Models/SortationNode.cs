using ColdSort.Core.Enums;
using ColdSort.Core.Interfaces.Models;
using System;

namespace ColdSort.Model.Models
{
    public class SortationNode : ISortationNode
    {
        public string Name { get; set; }
        public SongProperty SongProperty { get; set; }
        public bool AllowSortEnd { get; set; }
        public bool UseAbbreviation { get; set; }

        public SortationNode()
        {
            Name = "";
            SongProperty = 0;
            AllowSortEnd = true;
            UseAbbreviation = false;
        }

        public string GetSortationNodeProperty()
        {
            return SongProperty.ToString();
        }

        public override String ToString()
        {
            return Name;
        }
    }
}