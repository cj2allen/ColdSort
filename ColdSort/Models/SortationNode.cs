using ColdSort.Core.Enums;
using ColdSort.Core.Interfaces.Models;
using System;

namespace ColdSort.Models
{
    public class SortationNode : ISortationNode
    {
        public string Name
        {
            get
            {
                string abbrivation = UseAbbreviation ? ", Use Abbr." : "";
                string end = AllowSortEnd ? ", Can End" : "";
                return string.Format("{0}{1}{2}", SongProperty.ToString(), abbrivation, end);
            }
        }
        public SongProperty SongProperty { get; set; }
        public bool AllowSortEnd { get; set; }
        public bool UseAbbreviation { get; set; }

        public SortationNode()
        {
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