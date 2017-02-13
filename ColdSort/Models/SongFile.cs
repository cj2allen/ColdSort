//-----------------------------------------------------------------------
// <copyright file="MP3File.cs" company="None">
//     Copyright (c) 2016 Christopher James Allen
// </copyright>
// <author>Christopher James Allen</author>
//-----------------------------------------------------------------------

using System.IO;

namespace ColdSort.Models
{
    /// <summary>
    /// Data and methods related to an MP3 file
    /// </summary>
    public class SongFile
    {
        #region Properties

        /// <summary>
        /// Gets or sets a value of the title
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets a value of the primary artist
        /// </summary>
        public string Artist { get; set; }

        /// <summary>
        /// Gets or sets a value of all the artists (if possible)
        /// </summary>
        public string Artists { get; set; }

        /// <summary>
        /// Gets or sets a value of the album
        /// </summary>
        public string Album { get; set; }

        /// <summary>
        /// Gets or sets a value of the year
        /// </summary>
        public string Year { get; set; }

        /// <summary>
        /// Gets or sets a value of the genre
        /// </summary>
        public string Genre { get; set; }

        /// <summary>
        /// Gets or sets a value of the disc number
        /// </summary>
        public string Disc { get; set; }

        /// <summary>
        /// Gets or sets a value of the bitrate
        /// </summary>
        public string Bitrate { get; set; }

        /// <summary>
        /// Gets or sets a value of the original path of the song file
        /// </summary>
        public string OriginalPath { get; set; }

        /// <summary>
        /// Gets or sets the value of the sorted path of the song file
        /// </summary>
        public string SortedPath { get; set; }

        /// <summary>
        /// <see cref="SongFile.OriginalFilename" />
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
        /// <see cref="SongFile.SortedFilename" />
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
    }
}
