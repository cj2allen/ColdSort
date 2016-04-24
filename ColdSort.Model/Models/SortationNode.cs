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

        public SortationNodeResult Evaluate(ISongFile songFile, ref string newDirectory)
        {
            string newPathValue = songFile.GetType().GetProperty(SongProperty.ToString()).GetValue(songFile, null).ToString();

            if (String.IsNullOrEmpty(newPathValue) && (newPathValue.Trim().Length != 0))
            {
                if (UseAbbreviation)
                {
                    newPathValue = newPathValue.Substring(0, 1);
                }

                String.Format(@"%s\%s", newDirectory, newPathValue);

                return SortationNodeResult.NotSorted;
            }
            else if(AllowSortEnd)
            {
                return SortationNodeResult.Sorted;
            }

            return SortationNodeResult.Error;
        }

        public override String ToString()
        {
            return Name;
        }
    }
}