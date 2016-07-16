//-----------------------------------------------------------------------
// <copyright file="MP3File.cs" company="None">
//     Copyright (c) 2016 Christopher James Allen
// </copyright>
// <author>Christopher James Allen</author>
//-----------------------------------------------------------------------

using System.IO;
using ColdSort.Core.Interfaces.Models;
using ATL;
using System;

namespace ColdSort.Models
{
    /// <summary>
    /// Data and methods related to an MP3 file
    /// </summary>
    public class SongFile : ISongFile
    {
        #region Properties

        /// <summary>
        /// <see cref="ISongFile.Title" />
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// <see cref="ISongFile.Artist" />
        /// </summary>
        public string Artist { get; set; }
        
        /// <summary>
        /// <see cref="ISongFile.Album" />
        /// </summary>
        public string Album { get; set; }
        
        /// <summary>
        /// <see cref="ISongFile.Year" />
        /// </summary>
        public string Year { get; set; }
        
        /// <summary>
        /// <see cref="ISongFile.OriginalPath" />
        /// </summary>
        public string OriginalPath { get; set; }
        
        /// <summary>
        /// <see cref="ISongFile.SortedPath" />
        /// </summary>
        public string SortedPath { get; set; }

        /// <summary>
        /// <see cref="ISongFile.Genre" />
        /// </summary>
        public string Genre { get; set; }

        /// <summary>
        /// <see cref="ISongFile.SortedFilename" />
        /// </summary>
        public string Disc { get; set; }

        /// <summary>
        /// <see cref="ISongFile.SortedFilename" />
        /// </summary>
        public string Bitrate { get; set; }

        /// <summary>
        /// <see cref="ISongFile.OriginalFilename" />
        /// </summary>
        public string OriginalFilename
        {
            get
            {
                if (!string.IsNullOrEmpty(OriginalPath))
                {
                    return Path.GetFileName(OriginalPath);
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
                if (!string.IsNullOrEmpty(SortedPath))
                {
                    return Path.GetFileName(SortedPath);
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
            OriginalPath = path;

            try
            {
                Track track = new Track(path);
                Title = track.Title;
                Artist = track.Artist;
                Album = track.Album;
                Year = track.Year.ToString();
                Genre = track.Genre;
                Disc = track.DiscNumber.ToString();
                Bitrate = track.Bitrate.ToString();

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
