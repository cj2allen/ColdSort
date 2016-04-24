using ColdSort.Core.Enums;
using ColdSort.Core.Interfaces.Models;
using ColdSort.Model.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ColdSort.Controller.Controllers
{
    public static class SortationService
    {
        public const string MP3_EXTENSION = "mp3";

        #region Scanning For Music

        public static List<ISongFile> GetSongFiles(string path)
        {
            List<ISongFile> songFiles = new List<ISongFile>();

            try
            {
                foreach (string subDirectory in Directory.GetDirectories(path))
                {
                    foreach(string file in Directory.GetFiles(subDirectory))
                    {
                        string extension = file.Split('.').Last().ToLower();
                        ISongFile songFile = null;

                        switch (extension)
                        {
                            case MP3_EXTENSION:
                                songFile = new MP3File();
                                songFile.LoadSongInformation(file);
                                break;
                            default:
                                break;
                        }

                        songFiles.Add(songFile);
                    }
                }

                return songFiles;
            }
            catch
            {
                //TODO throw something
                return null;
            }
        }

        #endregion

        #region Get Sortation Paths

        public static List<ISortationSchemaResult> GenerateSortationPaths(ISortationSchema sortationSchema, List<ISongFile> songFiles, string newRootPath)
        {
            List<ISortationSchemaResult> sortationSchemaResults = new List<ISortationSchemaResult>();

            foreach (ISongFile songFile in songFiles)
            {
                SortNodeResult result = SortNodeResult.NotSorted;
                string builtPath = newRootPath;
                int sortationNodePosition = 0;

                while ((result == SortNodeResult.NotSorted) && (sortationNodePosition < sortationSchema.SortationNodes.Count()))
                {
                    string newDirectory = "";
                    result = GenerateNodeValue (sortationSchema.SortationNodes[sortationNodePosition], songFile, ref newDirectory);

                    if ((result == SortNodeResult.Sorted) || (result == SortNodeResult.Error))
                    {
                        sortationSchemaResults.Add((ISortationSchemaResult)new SuccessfulSortation
                        {
                            OriginalPath = songFile.OriginalPath,
                            SortedPath = songFile.SortedPath
                        });
                    }
                    else
                    {
                        sortationSchemaResults.Add((ISortationSchemaResult)new FailedSortation
                        {
                            OriginalPath = songFile.OriginalPath,
                            ErrorMessage = result.ToString()
                        });
                    }
                }
            }

            return sortationSchemaResults;
        }

        private static SortNodeResult GenerateNodeValue (ISortationNode sortationNode, ISongFile songFile, ref string newDirectory)
        {
            string newPathValue;
            switch (sortationNode.SongProperty)
            {
                case (SongProperty.Album):
                    newPathValue = songFile.Album;
                    break;
                case (SongProperty.Artist):
                    newPathValue = songFile.Artist;
                    break;
                case (SongProperty.Title):
                    newPathValue = songFile.Title;
                    break;
                default:
                    newPathValue = songFile.Year;
                    break;
            }

            if (String.IsNullOrEmpty(newPathValue) && (newPathValue.Trim().Length != 0))
            {
                if (sortationNode.UseAbbreviation)
                {
                    newPathValue = newPathValue.Substring(0, 1); 
                }

                String.Format(@"%s\%s", newDirectory, newPathValue);

                return SortNodeResult.NotSorted;
            }
            else if (sortationNode.AllowSortEnd)
            {
                return SortNodeResult.Sorted;
            }

            return SortNodeResult.Error;
        }

        #endregion

        public static void MoveMusic (List<ISongFile> songFiles)
        {
            foreach (ISongFile songFile in songFiles)
            {
                List<ISortationResult> sortationResults = new List<ISortationResult>();
                string errorMessage = "";
                bool isSorted = false;

                try
                {
                    File.Move(songFile.OriginalPath, songFile.SortedPath);
                    isSorted = true;
                }
                catch (Exception e)
                {
                    errorMessage = e.ToString();
                }

                sortationResults.Add(new SortationResult
                {
                    OriginalPath = songFile.OriginalPath,
                    SortedPath = songFile.SortedPath,
                    IsSorted = isSorted,
                    ErrorMessage = errorMessage
                });

            }
        }
    }
}
