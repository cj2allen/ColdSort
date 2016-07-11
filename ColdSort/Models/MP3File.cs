//-----------------------------------------------------------------------
// <copyright file="MP3File.cs" company="None">
//     Copyright (c) 2016 Christopher James Allen
// </copyright>
// <author>Christopher James Allen</author>
//-----------------------------------------------------------------------

using System;
using System.IO;
using ColdSort.Core.Interfaces.Models;

namespace ColdSort.Models
{
    /// <summary>
    /// Data and methods related to an MP3 file
    /// </summary>
    public class MP3File : ISongFile
    {
        #region Fields

        /// <summary>
        /// The song's title
        /// </summary>
        private string _title = string.Empty;

        /// <summary>
        /// The song's artist
        /// </summary>
        private string _artist = string.Empty;

        /// <summary>
        /// The song's album
        /// </summary>
        private string _album = string.Empty;

        /// <summary>
        /// The song's year it came out
        /// </summary>
        private string _year = string.Empty;

        /// <summary>
        /// The song's original path
        /// </summary>
        private string _originalPath = string.Empty;

        /// <summary>
        /// The song's sorted path
        /// </summary>
        private string _sortedPath = string.Empty;

        #endregion

        #region Properties

        /// <summary>
        /// <see cref="ISongFile.Title" />
        /// </summary>
        public string Title
        {
            get
            {
                return _title;
            }

            set
            {
                _title = value;
            }
        }

        /// <summary>
        /// <see cref="ISongFile.Artist" />
        /// </summary>
        public string Artist
        {
            get
            {
                return _artist;
            }

            set
            {
                _artist = value;
            }
        }

        /// <summary>
        /// <see cref="ISongFile.Album" />
        /// </summary>
        public string Album
        {
            get
            {
                return _album;
            }

            set
            {
                _album = value;
            }
        }

        /// <summary>
        /// <see cref="ISongFile.Year" />
        /// </summary>
        public string Year
        {
            get
            {
                return _year;
            }

            set
            {
                _year = value;
            }
        }

        /// <summary>
        /// <see cref="ISongFile.OriginalPath" />
        /// </summary>
        public string OriginalPath
        {
            get
            {
                return _originalPath;
            }

            set
            {
                _originalPath = value;
            }
        }

        /// <summary>
        /// <see cref="ISongFile.SortedPath" />
        /// </summary>
        public string SortedPath
        {
            get
            {
                return _sortedPath;
            }

            set
            {
                _sortedPath = value;
            }
        }

        /// <summary>
        /// <see cref="ISongFile.OriginalFilename" />
        /// </summary>
        public string OriginalFilename
        {
            get
            {
                if (_originalPath != null)
                {
                    return Path.GetFileName(_originalPath);
                }

                return string.Empty;
            }
        }

        /// <summary>
        /// <see cref="ISongFile.SortedFilename" />
        /// </summary>
        public string SortedFilename
        {
            get
            {
                if (_sortedPath != null)
                {
                    return Path.GetFileName(_sortedPath);
                }

                return string.Empty;
            }
        }

        #endregion

        #region Methods

        /// <summary>
        /// <see cref="ISongFile.LoadSongInformation(string)" />
        /// </summary>
        /// <param name="path"> Path to the MP3 file </param>
        /// <returns> If it was successful in loading song information</returns>
        public bool LoadSongInformation(string path)
        {
            _originalPath = path;

            try
            {
                TagLib.File tagFile = TagLib.File.Create(path);
                _title = tagFile.Tag.Title;
                _artist = string.Join(", ", tagFile.Tag.AlbumArtists);
                _album = tagFile.Tag.Album;
                _year = tagFile.Tag.Year.ToString();

                return true;
            }
            catch
            {
                return false;
            }
        }

        #endregion
    }
}
