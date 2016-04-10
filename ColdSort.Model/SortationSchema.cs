using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColdSort
{
    public class SortationSchema
    {
        List<SortationNode> sortationNodes;
        string rootFilePath;

        private List<Tuple<string, string, SortationNodeResult>> sortPathingResults;
        private List<Tuple<string, SortErrorCode, string>> sortProcessedResult;

        public void GenerateSortPaths(List<ISongFile> songFiles)
        {
            sortPathingResults = new List<Tuple<string, string, SortationNodeResult>>();

            foreach (ISongFile songFile in songFiles)
            {
                SortationNodeResult result = SortationNodeResult.NotSorted;
                string newFilePath = rootFilePath;
                int sortationNodePosition = 0;

                while ((result == SortationNodeResult.NotSorted) && (sortationNodePosition < sortationNodes.Count()))
                {
                    string newDirectory = "";
                    result = sortationNodes[sortationNodePosition].Evaluate(songFile, ref newDirectory);

                    if((result == SortationNodeResult.Sorted) || (result == SortationNodeResult.Error))
                    {
                        sortPathingResults.Add(new Tuple<string, string, SortationNodeResult>(newDirectory, sortationNodes[sortationNodePosition].GetSortationNodeProperty(), result));
                    }
                    else
                    {

                    }
                }
            }
        }
    }
}
