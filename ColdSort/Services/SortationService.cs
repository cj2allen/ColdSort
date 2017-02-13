//-----------------------------------------------------------------------
// <copyright file="SortationService.cs" company="None">
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
using ColdSort.Models;
using ColdSort.Views;
using ColdSort.Enums;
using ColdSort.Factories;

namespace ColdSort.Services
{
    /// <summary>
    /// Manage sortation related functionality
    /// </summary>
    public class SortationService
    {
        #region Constants

        /// <summary>
        /// All valid music extensions
        /// </summary>
        public static readonly string[] VALID_EXTENSIONS = { ".mp3", ".acc", ".m4a", ".flac", ".mid", ".midi", ".ape", ".ogg", ".wav", ".wma" };

        /// <summary>
        /// Invalid folder characters
        /// </summary>
        public static readonly char[] INVALID_CHARACTERS = { '<', '>', ':', '"', '/', '\\', '|', '?', '*' };

        /// <summary>
        /// Max path length in Windows
        /// </summary>
        public static readonly int MAX_PATH_LENGTH = 260;

        /// <summary>
        /// Symbol for numbers that are being condensed
        /// </summary>
        public static readonly string CONDENSE_NUMBER_SYMBOL = "#";

        /// <summary>
        /// Symbol for symbols that are being condensed
        /// </summary>
        public static readonly string CONDENSE_SYMBOLS_SYMBOL = "!Symbols";

        /// <summary>
        /// Accented characters
        /// </summary>
        public static readonly string ACCENTED_CHARACTERS = "éèëêÉÈËÊàâäáãåÀÁÂÃÄÅÙÚÛÜùúûüµðòóôõöøÒÓÔÕÖØìíîïÌÍÎÏšŠñÑçÇÿŸžŽÐ";

        /// <summary>
        /// Accented Character Swap
        /// </summary>
        /// <remarks>
        /// Accented character conversion provided by Julien Roncaglia
        /// See original stack overflow post: http://stackoverflow.com/questions/5459641/replacing-characters-in-c-sharp-ascii
        /// </remarks>
        public static readonly Dictionary<char, char> ACCENTED_CHARACTERS_DICTIONARY = new Dictionary<char, char>()
        {
            {'é', 'e'}, {'è', 'e'}, {'ë', 'e'}, {'ê', 'e'}, {'É', 'E'}, {'È', 'E'}, {'Ë', 'E'}, {'Ê', 'E'}, {'à', 'a'}, {'â', 'a'},
            {'ä', 'a'}, {'á', 'a'}, {'ã', 'a'}, {'å', 'a'}, {'À', 'A'}, {'Á', 'A'}, {'Â', 'A'}, {'Ã', 'A'}, {'Ä', 'A'}, {'Å', 'A'},
            {'Ù', 'U'}, {'Ú', 'U'}, {'Û', 'U'}, {'Ü', 'U'}, {'ù', 'u'}, {'ú', 'u'}, {'û', 'u'}, {'ü', 'u'}, {'µ', 'u'}, {'ð', 'o'},
            {'ò', 'o'}, {'ó', 'o'}, {'ô', 'o'}, {'õ', 'o'}, {'ö', 'o'}, {'ø', 'o'}, {'Ò', 'O'}, {'Ó', 'O'}, {'Ô', 'O'}, {'Õ', 'O'},
            {'Ö', 'O'}, {'Ø', 'O'}, {'ì', 'i'}, {'í', 'i'}, {'î', 'i'}, {'ï', 'i'}, {'Ì', 'I'}, {'Í', 'I'}, {'Î', 'I'}, {'Ï', 'I'},
            {'š', 's'}, {'Š', 'S'}, {'ñ', 'n'}, {'Ñ', 'N'}, {'ç', 'c'}, {'Ç', 'C'}, {'ÿ', 'y'}, {'Ÿ', 'Y'}, {'ž', 'z'}, {'Ž', 'Z'}, {'Ð', 'D'}
        };

        #endregion

        #region Members

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
        private SortationSchema _sortationSchema;

        /// <summary>
        /// The progress view form
        /// </summary>
        private MainView _mainView;

        /// <summary>
        /// Background sorting worker
        /// </summary>
        private BackgroundWorker _backgroundWorker;
        
        #endregion

        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="SortationService"/> class
        /// </summary>
        /// <param name="mainView"> The progress view </param>
        /// <param name="sortationSchema"> The sortation schema </param>
        public SortationService(MainView mainView, SortationSchema sortationSchema, string oldRootPath, string newRootPath)
        {
            _sortationSchema = sortationSchema;
            _oldRootPath = oldRootPath;
            _newRootPath = newRootPath;
            _mainView = mainView;
            _mainView.SetController(this);
        }

        #endregion

        #region Methods

        /// <summary>
        /// Sorts the music in the original folder path to the new folder path using the given sortation schema. No diagnostics are collected.
        /// </summary>
        /// <param name="oldRootpath"> The original folder path </param>
        /// <param name="newRootPath"> The destination folder path </param>
        public void SortWithoutDiagnostics()
        {
            _backgroundWorker = new BackgroundWorker();
            _backgroundWorker.WorkerReportsProgress = true;
            _backgroundWorker.DoWork += new DoWorkEventHandler(BackgroundWorker_DoWork);
            _backgroundWorker.ProgressChanged += new ProgressChangedEventHandler(this.BackgroundWorker_ProgressChanged);
            _backgroundWorker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(BackgroundWorker_RunWorkerCompleted);
            _backgroundWorker.RunWorkerAsync();
        }

        /// <summary>
        /// Cancels the sortation
        /// </summary>
        public void CancelSort()
        {
            _backgroundWorker.CancelAsync();
            _mainView.Close();
        }

        /// <summary>
        /// Take a path to a valid music file and converts it to an SongFile
        /// </summary>
        /// <param name="songFilePath"> The path to a song file </param>
        /// <returns> The music file information </returns>
        public SongFile ConvertPathToSongFile(string songFilePath)
        {
            string extension = songFilePath.Split('.').LastOrDefault().ToLower();

            if (extension != null)
            {
                return SongFileFactory.Create(songFilePath);
            }

            return null;
        }

        /// <summary>
        /// Attempts to generate sort path for an SongFile 
        /// </summary>
        /// <param name="songFile"> The music file to be sorted </param>
        /// <param name="newRootPath"> The destination path to prefix to sort path </param>
        /// <returns> The result of the sort </returns>
        private SortationResult CreateSortationPath(SongFile songFile)
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
                return new SortationResult
                {
                    OriginalPath = songFile.OriginalPath,
                    SortedPath = songFile.SortedPath,
                    ErrorMessage = result.ToString()
                };
            }
            else
            {
                songFile.SortedPath = Path.Combine(songFile.SortedPath, songFile.OriginalFilename);
                return new SortationResult
                {
                    OriginalPath = songFile.OriginalPath,
                    SortedPath = songFile.SortedPath
                };
            }
        }

        /// <summary>
        /// Attempts to generate the next sorted path value for an SongFile
        /// </summary>
        /// <param name="sortationNode"> A sortation node </param>
        /// <param name="songFile"> The songFile that is having it's sorted path built </param>
        /// <returns> The result of the attempted sort path generation </returns>
        private SortNodeResult GenerateNodeValue(SortationNode sortationNode, ref SongFile songFile)
        {
            string newPathValue = GetSongProperty(sortationNode, songFile);

            if (_sortationSchema.FixIllegalCharacters)
            {
                foreach (char illegal in INVALID_CHARACTERS)
                {
                    newPathValue = newPathValue.Replace(illegal.ToString(), "");
                }
            }

            if (!string.IsNullOrEmpty(newPathValue)
                && (newPathValue.Trim().Length > 0)
                && (!_sortationSchema.FixIllegalCharacters || 
                    (newPathValue.IndexOfAny(INVALID_CHARACTERS) == -1))
                && (songFile.SortedPath.Length <= MAX_PATH_LENGTH))
            {
                if (sortationNode.UseAbbreviation)
                {
                    newPathValue = AbbreviationCreation(sortationNode, newPathValue);
                }
                
                songFile.SortedPath = Path.Combine(songFile.SortedPath, newPathValue);

                return SortNodeResult.NotSorted;
            }
            else if (sortationNode.AllowSortEnd)
            {
                return SortNodeResult.Sorted;
            }

            if (_sortationSchema.KeepFilesAtOriginalLocation)
            {
                songFile.SortedPath = songFile.OriginalPath;
            }
            else
            {
                songFile.SortedPath = Path.Combine(_newRootPath, _sortationSchema.FailedSortationDefault, songFile.OriginalFilename);
            }

            return SortNodeResult.Error;
        }

        private string GetSongProperty(SortationNode sortationNode, SongFile songFile)
        {
            string newPathValue = "";

            switch (sortationNode.SongProperty)
            {
                case SongProperty.Album:
                    newPathValue = songFile.Album;
                    break;
                case SongProperty.Artist:
                    newPathValue = songFile.Artist;
                    break;
                case SongProperty.Artists:
                    if (!sortationNode.UseAbbreviation)
                    {
                        var artists = songFile.Artists.Split('/');

                        for (int i = 0; i < artists.Length; i++)
                        {
                            if (i == 0)
                            {
                                newPathValue = artists[i];
                            }
                            else if (i == 1)
                            {
                                newPathValue += $" (Feat. {artists[i]}";
                            }
                            else if (i != artists.Length - 1)
                            {
                                newPathValue += $", {artists[i]}";
                            }
                            else
                            {
                                newPathValue += $", and {artists[i]}";
                            }

                            if (i != 0 && i == artists.Length - 1)
                            {
                                newPathValue += $")";
                            }
                        }
                    }
                    else
                    {
                        newPathValue = songFile.Artist.Split('/').First();
                    }
                    break;
                case SongProperty.Title:
                    newPathValue = songFile.Title;
                    break;
                case SongProperty.Year:
                    newPathValue = songFile.Year;
                    break;
                case SongProperty.Genre:
                    newPathValue = songFile.Genre;
                    break;
                case SongProperty.Disc:
                    newPathValue = songFile.Disc;
                    break;
                default:
                    newPathValue = songFile.Bitrate;
                    break;
            }

            return newPathValue;
        }

        private string AbbreviationCreation(SortationNode sortationNode, string newPathValue)
        {
            char abbreviation = newPathValue[0];

            if (sortationNode.CondenseNumbersToSymbol && (abbreviation >= '0' && abbreviation <= '9'))
            {
                return CONDENSE_NUMBER_SYMBOL;
            }
            else if ((sortationNode.CondenseAccents) && (ACCENTED_CHARACTERS.Contains(abbreviation)))
            {
                return ACCENTED_CHARACTERS_DICTIONARY[abbreviation].ToString();
            }
            else if (sortationNode.CondenseSymbols &&
                !(abbreviation >= 'a' && abbreviation <= 'z') &&
                !(abbreviation >= 'A' && abbreviation <= 'Z') &&
                !(abbreviation >= '0' && abbreviation <= '9'))
            {
                return CONDENSE_SYMBOLS_SYMBOL;
            }

            if (sortationNode.CapitalizeAbbreviation &&
                (abbreviation >= 'a' && abbreviation <= 'z'))
            {
                return abbreviation.ToString().ToUpper();
            }

            return abbreviation.ToString();
        }

        

        /// <summary>
        /// <see cref="ISortationService.GenerateSortationPaths(List{SongFile})"/>
        /// </summary>
        /// <param name="songFiles"> A list of music files to be sorted </param>
        /// <returns> A list of results of the sort </returns>
        public List<SortationResult> GenerateSortationPaths(List<SongFile> songFiles)
        {
            List<SortationResult> sortationSchemaResults = new List<SortationResult>();

            foreach (SongFile songFile in songFiles)
            {
                sortationSchemaResults.Add(CreateSortationPath(songFile));
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
                _mainView.UpdateProgress(e.ProgressPercentage);
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

            string[] files = Directory.GetFiles(_oldRootPath, "*.*", SearchOption.AllDirectories)
                    .Where(x => VALID_EXTENSIONS.Contains(Path.GetExtension(x).ToLower())).ToArray();
            totalFileCount = files.Length;

            foreach (string file in files)
            {
                currentFileCount++;

                int percentage = (int)Math.Ceiling(currentFileCount / totalFileCount * 100);
                _backgroundWorker.ReportProgress(percentage);

                SongFile songFile = ConvertPathToSongFile(file);

                if (songFile != null)
                {
                    SortationResult sortationSchemaResult = CreateSortationPath(songFile);
                    MoveCopyResult moveCopyResult = FilePathingService.MoveSongFile(songFile, _sortationSchema.CopySongs);
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
        }

        #endregion
    }
}
