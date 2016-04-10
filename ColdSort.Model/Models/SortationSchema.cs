using ColdSort.Core.Enums;
using ColdSort.Core.Interfaces.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ColdSort.Model.Models
{
    public class SortationSchema : ISortationSchema
    {
        public string SortationSchemaTitle { get; set; }
        public string FailedSortationDefault { get; set; }
        public List<ISortationNode> SortationNodes { get; set; }
        public bool KeepFilesAtOriginalLocation { get; set; }
        public List<ISortationSchemaResult> SortPathingResults { get; set; }

        public void GenerateSortPaths(List<ISongFile> songFiles, string rootPath)
        {
            SortPathingResults = new List<ISortationSchemaResult>();

            foreach (ISongFile songFile in songFiles)
            {
                SortationNodeResult result = SortationNodeResult.NotSorted;
                string newFilePath = rootPath;
                int sortationNodePosition = 0;

                while ((result == SortationNodeResult.NotSorted) && (sortationNodePosition < SortationNodes.Count()))
                {
                    string newDirectory = "";
                    result = SortationNodes[sortationNodePosition].Evaluate(songFile, ref newDirectory);

                    if((result == SortationNodeResult.Sorted) || (result == SortationNodeResult.Error))
                    {
                        SortPathingResults.Add((ISortationSchemaResult) new SuccessfulSortation
                        {
                            OriginalPath = songFile.OriginalPath,
                            SortedPath = songFile.SortedPath
                        });
                    }
                    else
                    {
                        SortPathingResults.Add((ISortationSchemaResult) new FailedSortation
                        {
                            OriginalPath = songFile.OriginalPath,
                            ErrorMessage = result.ToString()
                        });
                    }
                }
            }
        }

        public override String ToString()
        {
            return SortationSchemaTitle;
        }
    }
}
