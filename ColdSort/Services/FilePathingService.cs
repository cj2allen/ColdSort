using ColdSort.Factories;
using ColdSort.Models;
using System;
using System.Collections.Generic;
using System.IO;

namespace ColdSort.Services
{
    public static class FilePathingService
    {
        /// <summary>
        /// Attempts to move a song file
        /// </summary>
        /// <param name="songFile"> The information of the song file being moved </param>        
        /// <returns> The result of the attempted move </returns>
        public static MoveCopyResult MoveSongFile(SongFile songFile, bool copySongs)
        {
            MoveCopyResult result = new MoveCopyResult
            {
                OriginalPath = songFile.OriginalPath,
                SortedPath = songFile.SortedPath,
                ErrorMessage = ""
            };

            while (result.Successful == false && string.IsNullOrEmpty(result.ErrorMessage))
            {
                try
                {
                    if (!copySongs)
                    {
                        File.Move(songFile.OriginalPath, songFile.SortedPath);
                    }
                    else
                    {
                        File.Copy(songFile.OriginalPath, songFile.SortedPath);
                    }
                }
                catch (ArgumentNullException)
                {
                    result.ErrorMessage = "Supplied original or sorted paths were empty.";
                }
                catch (ArgumentException)
                {
                    result.ErrorMessage = "The attempted sortation path had invalid characters.";
                }
                catch (DirectoryNotFoundException)
                {
                    try
                    {
                        Directory.CreateDirectory(Path.GetDirectoryName(songFile.SortedPath));
                    }
                    catch
                    {
                        result.ErrorMessage = "Unable to create folder path for file.";
                    }
                }
                catch (FileNotFoundException)
                {
                    result.ErrorMessage = "The original file is no longer at original location.";
                }
                catch (PathTooLongException)
                {
                    result.ErrorMessage = "The sorted path is too long.";
                }
                catch (IOException)
                {
                    //This needs to be fixed
                    songFile.SortedPath += " - Conflict";
                }
                catch (NotSupportedException)
                {
                    result.ErrorMessage = "Somehow this file format is not supported. Should not see this message.";
                }
                catch (UnauthorizedAccessException)
                {
                    result.ErrorMessage = "User does not have access rights for writing to the sorted path";
                }
            }

            return result;
        }

        /// <summary>
        /// Attempts to move multiple song file
        /// </summary>
        /// <param name="songFiles"> The information of the song files that are being moved </param>
        public static void MoveSongFiles(List<SongFile> songFiles, bool copySongs)
        {
            List<MoveCopyResult> sortationResults = new List<MoveCopyResult>();

            foreach (SongFile songFile in songFiles)
            {
                sortationResults.Add(MoveSongFile(songFile, copySongs));
            }
        }

        /// <summary>
        /// Recursively finds all valid music files in a directory
        /// </summary>        
        /// <returns> A list of SongFiles of music files recursively collected from the directory </returns>
        public static List<SongFile> GetMusicFiles(string rootPath)
        {
            List<SongFile> songFiles = new List<SongFile>();

            foreach (string subDirectory in Directory.GetDirectories(rootPath))
            {
                foreach (string filepath in Directory.GetFiles(subDirectory))
                {
                    SongFile songFile = SongFileFactory.Create(filepath);
                    songFiles.Add(songFile);
                }
            }

            return songFiles;
        }
    }
}
