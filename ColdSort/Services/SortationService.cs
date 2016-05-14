using ColdSort.Core.Enums;
using ColdSort.Core.Interfaces.Models;
using ColdSort.Views;
using ColdSort.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;

namespace ColdSort.Controllers
{
    public static class SortationService
    {
        public const string MP3_EXTENSION = "mp3";
        public static readonly char[] INVALID_CHARACTERS = { '<', '>', ':', '"', '/', '\\', '|', '?', '*' };

        public static string CombineExtensions()
        {
            return String.Format("*.{0}", MP3_EXTENSION);
        }

        public static void SortWithNoDiagnostics(string oldRootpath, string newRootPath, ISortationSchema sortationSchema)
        {
            using (ProgressView progressView = new ProgressView())
            {
                string[] files = Directory.GetFiles(oldRootpath, CombineExtensions(), SearchOption.AllDirectories);

                progressView.SetFileCount(files.Length);

                foreach (string file in files)
                {
                    progressView.UpdateInfo(file);

                    ISongFile songFile = ConvertPathToISongFile(file);

                    if (songFile != null)
                    {
                        ISortationSchemaResult sortationSchemaResult = CreateSortationPath(sortationSchema, songFile, newRootPath);
                        if (sortationSchemaResult is SuccessfulSortation)
                        {
                            Thread.Sleep(50);
                            //MoveSongFile(songFile);
                        }
                    }
                }
            }
        }


        #region Scanning For Music

        private static ISongFile ConvertPathToISongFile (string songFilePath)
        {
            string extension = songFilePath.Split('.').LastOrDefault().ToLower();

            if (extension != null)
            {
                ISongFile songFile;

                switch (extension)
                {
                    case MP3_EXTENSION:
                        songFile = new MP3File();
                        break;
                    default:
                        songFile = null;
                        break;
                }

                if (songFile != null && songFile.LoadSongInformation(songFilePath))
                {
                    return songFile;
                }
            }

            return null;
        }

        public static List<ISongFile> GetSongFiles(string path)
        {
            List<ISongFile> songFiles = new List<ISongFile>();

            foreach (string subDirectory in Directory.GetDirectories(path))
            {
                foreach(string file in Directory.GetFiles(subDirectory))
                {
                    ISongFile songFile = ConvertPathToISongFile(file);
                    songFiles.Add(songFile);
                }
            }

            return songFiles;
        }

        #endregion

        #region Get Sortation Paths

        private static ISortationSchemaResult CreateSortationPath (ISortationSchema sortationSchema, ISongFile songFile, string newRootPath)
        {
            SortNodeResult result = SortNodeResult.NotSorted;

            foreach (SortationNode sortationNode in sortationSchema.SortationNodes)
            {   
                result = GenerateNodeValue(sortationNode, ref songFile);

                if (result != SortNodeResult.NotSorted)
                {
                    break;
                }
            }

            if (result == SortNodeResult.Error)
            {
                return (ISortationSchemaResult) new FailedSortation
                {
                    OriginalPath = songFile.OriginalPath,
                    ErrorMessage = result.ToString()
                };
            }
            else
            {
                return (ISortationSchemaResult) new SuccessfulSortation
                {
                    OriginalPath = songFile.OriginalPath,
                    SortedPath = songFile.SortedPath
                };
            }
        }

        public static List<ISortationSchemaResult> GenerateSortationPaths(ISortationSchema sortationSchema, List<ISongFile> songFiles, string newRootPath)
        {
            List<ISortationSchemaResult> sortationSchemaResults = new List<ISortationSchemaResult>();

            foreach (ISongFile songFile in songFiles)
            {
                sortationSchemaResults.Add(CreateSortationPath(sortationSchema, songFile, newRootPath));
            }

            return sortationSchemaResults;
        }

        private static SortNodeResult GenerateNodeValue (ISortationNode sortationNode, ref ISongFile songFile)
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

            if (!String.IsNullOrEmpty(newPathValue)
                && (newPathValue.Trim().Length > 0)
                && (newPathValue.IndexOfAny(INVALID_CHARACTERS) == -1))
            {
                if (sortationNode.UseAbbreviation)
                {
                    newPathValue = newPathValue.Substring(0, 1); 
                }

                String.Format(@"%s\%s", songFile.SortedPath, newPathValue);

                return SortNodeResult.NotSorted;
            }
            else if (sortationNode.AllowSortEnd)
            {
                return SortNodeResult.Sorted;
            }

            return SortNodeResult.Error;
        }

        #endregion

        private static ISortationResult MoveSongFile(ISongFile songFile)
        {
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

            return new SortationResult
            { 
                OriginalPath = songFile.OriginalPath,
                SortedPath = songFile.SortedPath,
                IsSorted = isSorted,
                ErrorMessage = errorMessage
            };
        }

        public static void MoveSongFiles (List<ISongFile> songFiles)
        {
            List<ISortationResult> sortationResults = new List<ISortationResult>();

            foreach (ISongFile songFile in songFiles)
            {
                sortationResults.Add(MoveSongFile(songFile));
            }
        }
    }
}
