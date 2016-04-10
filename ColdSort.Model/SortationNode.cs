using System;

namespace ColdSort
{
    public class SortationNode
    {
        private SongProperty sortSongProperty;
        private bool CanSongFinishHere;
        private bool UsePropertyAcronym;
        
        public SortationNode (SongProperty sortSongProperty, bool CanSongFinishHere, bool UsePropertyAcronym)
        {
            this.sortSongProperty = sortSongProperty;
            this.CanSongFinishHere = CanSongFinishHere;
            this.UsePropertyAcronym = UsePropertyAcronym;
        }

        public string GetSortationNodeProperty()
        {
            return sortSongProperty.ToString();
        }

        public SortationNodeResult Evaluate(ISongFile songFile, ref string newDirectory)
        {
            string newPathValue = songFile.GetType().GetProperty(sortSongProperty.ToString()).GetValue(songFile, null);

            if (String.IsNullOrEmpty(newPathValue) && (newPathValue.Trim().Length != 0))
            {
                if (UsePropertyAcronym)
                {
                    newPathValue = newPathValue.Substring(0, 1);
                }

                String.Format(@"%s\%s", newDirectory, newPathValue);

                return SortationNodeResult.NotSorted;
            }
            else if(CanSongFinishHere)
            {
                return SortationNodeResult.Sorted;
            }

            return SortationNodeResult.Error;
        }
    }
}