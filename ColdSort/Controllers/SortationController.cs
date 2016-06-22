//-----------------------------------------------------------------------
// <copyright file="SortationController.cs" company="None">
//     Copyright (c) 2016 Christopher James Allen
// </copyright>
// <author>Christopher James Allen</author>
//-----------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using ColdSort.Core.Enums;
using ColdSort.Core.Interfaces.Controllers;
using ColdSort.Core.Interfaces.Models;
using ColdSort.Models;
using ColdSort.Views;

namespace ColdSort.Controllers
{
    /// <summary>
    /// Manage sortation related functionality
    /// </summary>
    public class SortationController : ISortationController
    {
        #region Constants

        /// <summary>
        /// The MP3 file extension
        /// </summary>
        public const string MP3_EXTENSION = "mp3";

        /// <summary>
        /// Invalid folder characters
        /// </summary>
        public static readonly char[] INVALID_CHARACTERS = { '<', '>', ':', '"', '/', '\\', '|', '?', '*' };

        /// <summary>
        /// Max path length in Windows
        /// </summary>
        public static readonly int MAX_PATH_LENGTH = 260;

        #endregion

        #region Fields

        /// <summary>
        /// The source folder path of the music
        /// </summary>
        private string _oldRootPath;

        /// <summary>
        /// The destination folder path of the music
        /// </summary>
        private string _newRootPath;

        /// <summary>
        /// The sortation schema that will be used to sort the files
        /// </summary>
        private ISortationSchema _sortationSchema;

        /// <summary>
        /// The progress view form
        /// </summary>
        private ProgressView _progressView;

        /// <summary>
        /// Background sorting worker
        /// </summary>
        private BackgroundWorker _backgroundWorker;

        #endregion

        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="SortationController"/> class
        /// </summary>
        /// <param name="progressView"> The progress view </param>
        /// <param name="sortationSchema"> The sortation schema </param>
        public SortationController(ProgressView progressView, ISortationSchema sortationSchema)
        {
            _sortationSchema = sortationSchema;
            _progressView = progressView;
            _progressView.SetController(this);
        }

        #endregion

        #region Methods

        /// <summary>
        /// Sorts the music in the original folder path to the new folder path using the given sortation schema. No diagnostics are collected.
        /// </summary>
        /// <param name="oldRootpath"> The original folder path </param>
        /// <param name="newRootPath"> The destination folder path </param>
        public void SortWithoutDiagnostics(string oldRootpath, string newRootPath)
        {
            _oldRootPath = oldRootpath;
            _newRootPath = newRootPath;
            _backgroundWorker = new BackgroundWorker();
            _backgroundWorker.WorkerReportsProgress = true;
            _backgroundWorker.DoWork += new DoWorkEventHandler(BackgroundWorker_DoWork);
            _backgroundWorker.ProgressChanged += new ProgressChangedEventHandler(this.BackgroundWorker_ProgressChanged);
            _backgroundWorker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(BackgroundWorker_RunWorkerCompleted);
            _backgroundWorker.RunWorkerAsync();
            _progressView.ShowDialog();
        }

        /// <summary>
        /// Cancels the sortation
        /// </summary>
        public void CancelSort()
        {
            _backgroundWorker.CancelAsync();
            _progressView.Close();
        }

        /// <summary>
        /// Take a path to a valid music file and converts it to an ISongFile
        /// </summary>
        /// <param name="songFilePath"> The path to a song file </param>
        /// <returns> The music file information </returns>
        private ISongFile ConvertPathToISongFile(string songFilePath)
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

        /// <summary>
        /// This method combines all valid music file types into one pattern
        /// </summary>
        /// <returns> A regex pattern of all valid music file types </returns>
        private string CombineExtensions()
        {
            return string.Format("*.{0}", MP3_EXTENSION);
        }

        /// <summary>
        /// Recursively finds all valid music files in a directory
        /// </summary>
        /// <param name="path"> Directory of music files </param>
        /// <returns> A list of ISongFiles of music files recursively collected from the directory </returns>
        private List<ISongFile> GetMusicFiles(string path)
        {
            List<ISongFile> songFiles = new List<ISongFile>();

            foreach (string subDirectory in Directory.GetDirectories(path))
            {
                foreach (string file in Directory.GetFiles(subDirectory))
                {
                    ISongFile songFile = ConvertPathToISongFile(file);
                    songFiles.Add(songFile);
                }
            }

            return songFiles;
        }

        /// <summary>
        /// Attempts to generate sort path for an ISongFile 
        /// </summary>
        /// <param name="songFile"> The music file to be sorted </param>
        /// <param name="newRootPath"> The destination path to prefix to sort path </param>
        /// <returns> The result of the sort </returns>
        private ISortationSchemaResult CreateSortationPath(ISongFile songFile, string newRootPath)
        {
            SortNodeResult result = SortNodeResult.NotSorted;
            songFile.SortedPath = _newRootPath;

            foreach (SortationNode sortationNode in _sortationSchema.SortationNodes)
            {
                result = GenerateNodeValue(sortationNode, ref songFile);

                if (result != SortNodeResult.NotSorted)
                {
                    break;
                }
            }

            if (result == SortNodeResult.Error)
            {
                return (ISortationSchemaResult)new FailedSortation
                {
                    OriginalPath = songFile.OriginalPath,
                    ErrorMessage = result.ToString()
                };
            }
            else
            {
                songFile.SortedPath = string.Format(@"{0}\{1}", songFile.SortedPath, songFile.OriginalFilename);
                return (ISortationSchemaResult)new SuccessfulSortation
                {
                    OriginalPath = songFile.OriginalPath,
                    SortedPath = songFile.SortedPath
                };
            }
        }

        /// <summary>
        /// Attempts to generate the next sorted path value for an ISongFile
        /// </summary>
        /// <param name="sortationNode"> A sortation node </param>
        /// <param name="songFile"> The songFile that is having it's sorted path built </param>
        /// <returns> The result of the attempted sort path generation </returns>
        private SortNodeResult GenerateNodeValue(ISortationNode sortationNode, ref ISongFile songFile)
        {
            string newPathValue;

            switch (sortationNode.SongProperty)
            {
                case SongProperty.Album:
                    newPathValue = songFile.Album;
                    break;
                case SongProperty.Artist:
                    newPathValue = songFile.Artist;
                    break;
                case SongProperty.Title:
                    newPathValue = songFile.Title;
                    break;
                default:
                    newPathValue = songFile.Year;
                    break;
            }

            if (!string.IsNullOrEmpty(newPathValue)
                && (newPathValue.Trim().Length > 0)
                && (newPathValue.IndexOfAny(INVALID_CHARACTERS) == -1)
                && (Path.GetDirectoryName(songFile.SortedPath).Length <= MAX_PATH_LENGTH))
            {
                if (sortationNode.UseAbbreviation)
                {
                    newPathValue = newPathValue.Substring(0, 1);
                }

                songFile.SortedPath = string.Format(@"{0}\{1}", songFile.SortedPath, newPathValue);

                return SortNodeResult.NotSorted;
            }
            else if (sortationNode.AllowSortEnd)
            {
                return SortNodeResult.Sorted;
            }

            songFile.SortedPath = string.Format(@"{0}\{1}\{2}", _newRootPath, _sortationSchema.FailedSortationDefault, songFile.OriginalFilename);
            return SortNodeResult.Error;
        }

        /// <summary>
        /// Attempts to move a song file
        /// </summary>
        /// <param name="songFile"> The information of the song file being moved </param>        
        /// <returns> The result of the attempted move </returns>
        private ISortationResult MoveSongFile(ISongFile songFile)
        {
            string errorMessage = string.Empty;
            bool isSorted = false;

            try
            {
                if (File.Exists(songFile.SortedPath))
                {
                    File.Delete(songFile.SortedPath);
                }

                Directory.CreateDirectory(Path.GetDirectoryName(songFile.SortedPath));
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

        /// <summary>
        /// Attempts to move multiple song file
        /// </summary>
        /// <param name="songFiles"> The information of the song files that are being moved </param>
        private void MoveSongFiles(List<ISongFile> songFiles)
        {
            List<ISortationResult> sortationResults = new List<ISortationResult>();

            foreach (ISongFile songFile in songFiles)
            {
                sortationResults.Add(MoveSongFile(songFile));
            }
        }

        /// <summary>
        /// Attempts to generate sort path for a list of ISongFile 
        /// </summary>
        /// <param name="songFiles"> A list of music files to be sorted </param>
        /// <param name="newRootPath"> The destination path to prefix to sort path </param>
        /// <returns> A list of results of the sort </returns>
        private List<ISortationSchemaResult> GenerateSortationPaths(List<ISongFile> songFiles, string newRootPath)
        {
            List<ISortationSchemaResult> sortationSchemaResults = new List<ISortationSchemaResult>();

            foreach (ISongFile songFile in songFiles)
            {
                sortationSchemaResults.Add(CreateSortationPath(songFile, newRootPath));
            }

            return sortationSchemaResults;
        }

        #endregion

        #region Events

        /// <summary>
        /// Updates the progress of the Background Worker
        /// </summary>
        /// <param name="sender"> The sender </param>
        /// <param name="e"> The event </param>
        private void BackgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            if (e.ProgressPercentage > 0)
            {
                _progressView.UpdateProgress(e.ProgressPercentage);
            }
        }

        /// <summary>
        /// Background Worker work loop
        /// </summary>
        /// <param name="sender"> The sender </param>
        /// <param name="e"> The event </param>
        private void BackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            double currentFileCount = default(double);
            double totalFileCount = default(double);

            string[] files = Directory.GetFiles(_oldRootPath, CombineExtensions(), SearchOption.AllDirectories);
            totalFileCount = files.Length;

            foreach (string file in files)
            {
                currentFileCount++;

                int percentage = (int)Math.Ceiling(currentFileCount / totalFileCount * 100);
                _backgroundWorker.ReportProgress(percentage);

                ISongFile songFile = ConvertPathToISongFile(file);

                if (songFile != null)
                {
                    ISortationSchemaResult sortationSchemaResult = CreateSortationPath(songFile, _newRootPath);
                    MoveSongFile(songFile);
                }
            }
        }

        /// <summary>
        /// Background Worker reports that it's work is done
        /// </summary>
        /// <param name="sender"> The sender </param>
        /// <param name="e"> The event </param>
        private void BackgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled == true)
            {
                MessageBox.Show("Canceled!");
            }
            else if (e.Error != null)
            {
                MessageBox.Show("Error!");
            }
            else
            {
                MessageBox.Show("Done!");
            }

            _progressView.Close();
        }

        #endregion
    }
}
