using ColdSort.Core.Enums;
using ColdSort.Core.Interfaces.Models;
using ColdSort.Views;
using ColdSort.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.ComponentModel;
using System.Windows.Forms;
using ColdSort.Core.Interfaces.Controllers;

namespace ColdSort.Controllers
{
    public class SortationController : ISortationController
    {
        public const string MP3_EXTENSION = "mp3";
        public static readonly char[] INVALID_CHARACTERS = { '<', '>', ':', '"', '/', '\\', '|', '?', '*' };
        public static readonly int MAX_PATH_LENGTH = 260;

        private string _oldRootPath;
        private string _newRootPath;
        private ISortationSchema _sortationSchema;
        private ProgressView _progressView;
        private BackgroundWorker _backgroundWorker;

        public SortationController(ProgressView progressView)
        {
            _progressView = progressView;
            _progressView.SetController(this);
        }

        public void SortWithoutDiagnostics(string oldRootpath, string newRootPath, ISortationSchema sortationSchema)
        {
            _oldRootPath = oldRootpath;
            _newRootPath = newRootPath;
            _sortationSchema = sortationSchema;
            
            _backgroundWorker = new BackgroundWorker();
            _backgroundWorker.WorkerReportsProgress = true;
            _backgroundWorker.DoWork += new DoWorkEventHandler(backgroundWorker_DoWork);
            _backgroundWorker.ProgressChanged += new ProgressChangedEventHandler(this.backgroundWorker_ProgressChanged);
            _backgroundWorker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(backgroundWorker_RunWorkerCompleted);
            _backgroundWorker.RunWorkerAsync();
            _progressView.ShowDialog();
        }

        private void backgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            if (e.ProgressPercentage > 0)
            {
                _progressView.UpdateProgress(e.ProgressPercentage);
            }
        }

        public string CombineExtensions()
        {
            return String.Format("*.{0}", MP3_EXTENSION);
        }

        private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            double currentFileCount = default(double);
            double totalFileCount = default(double);

            string[] files = Directory.GetFiles(_oldRootPath, CombineExtensions(), SearchOption.AllDirectories);
            totalFileCount = files.Length;

            foreach (string file in files)
            {
                currentFileCount++;

                int percentage = (int) Math.Ceiling(currentFileCount / totalFileCount*100);
                _backgroundWorker.ReportProgress(percentage);

                ISongFile songFile = ConvertPathToISongFile(file);

                if (songFile != null)
                {
                    ISortationSchemaResult sortationSchemaResult = CreateSortationPath(_sortationSchema, songFile, _newRootPath);
                    MoveSongFile(songFile);                    
                }
            }
        }

        private void backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
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

        public void CancelSort()
        {
            _backgroundWorker.CancelAsync();
            _progressView.Close();
        }


        #region Scanning For Music

        private ISongFile ConvertPathToISongFile (string songFilePath)
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

        public List<ISongFile> GetSongFiles(string path)
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

        private ISortationSchemaResult CreateSortationPath (ISortationSchema sortationSchema, ISongFile songFile, string newRootPath)
        {
            SortNodeResult result = SortNodeResult.NotSorted;
            songFile.SortedPath = _newRootPath;

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
                songFile.SortedPath = String.Format(@"{0}\{1}", songFile.SortedPath, songFile.OriginalFilename);
                return (ISortationSchemaResult) new SuccessfulSortation
                {
                    OriginalPath = songFile.OriginalPath,
                    SortedPath = songFile.SortedPath
                };
            }
        }

        public List<ISortationSchemaResult> GenerateSortationPaths(ISortationSchema sortationSchema, List<ISongFile> songFiles, string newRootPath)
        {
            List<ISortationSchemaResult> sortationSchemaResults = new List<ISortationSchemaResult>();

            foreach (ISongFile songFile in songFiles)
            {
                sortationSchemaResults.Add(CreateSortationPath(sortationSchema, songFile, newRootPath));
            }

            return sortationSchemaResults;
        }

        private SortNodeResult GenerateNodeValue (ISortationNode sortationNode, ref ISongFile songFile)
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
                && (newPathValue.IndexOfAny(INVALID_CHARACTERS) == -1)
                && (Path.GetDirectoryName(songFile.SortedPath).Length <= MAX_PATH_LENGTH))
            {
                if (sortationNode.UseAbbreviation)
                {
                    newPathValue = newPathValue.Substring(0, 1); 
                }

               songFile.SortedPath = String.Format(@"{0}\{1}", songFile.SortedPath, newPathValue);

                return SortNodeResult.NotSorted;
            }
            else if (sortationNode.AllowSortEnd)
            {
                return SortNodeResult.Sorted;
            }

            songFile.SortedPath = String.Format(@"{0}\{1}\{2}", _newRootPath, _sortationSchema.FailedSortationDefault, songFile.OriginalFilename);
            return SortNodeResult.Error;
        }

        #endregion

        private ISortationResult MoveSongFile(ISongFile songFile)
        {
            string errorMessage = "";
            bool isSorted = false;

            try
            {
                if (File.Exists(songFile.SortedPath))
                {
                    File.Delete(songFile.SortedPath);
                }

                //System.Diagnostics.Debug.WriteLine(songFile.SortedPath);
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

        public void MoveSongFiles (List<ISongFile> songFiles)
        {
            List<ISortationResult> sortationResults = new List<ISortationResult>();

            foreach (ISongFile songFile in songFiles)
            {
                sortationResults.Add(MoveSongFile(songFile));
            }
        }     
    }
}
