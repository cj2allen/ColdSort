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

        public static List<ISongFile> Scan(string path)
        {
            List<ISongFile> songFiles = new List<ISongFile>();

            try
            {
                foreach (string subDirectory in Directory.GetDirectories(path))
                {
                    foreach(string file in Directory.GetFiles(subDirectory))
                    {
                        string extension = file.Split('.').Last().ToLower();

                        switch(extension)
                        {
                            case MP3_EXTENSION:
                                ISongFile mp3File = new MP3File();
                                mp3File.LoadSongInformation(file);
                                songFiles.Add(mp3File);
                                break;
                            default:
                                break;
                        }
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

        public static void Sort (List<ISongFile> songFiles)
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
