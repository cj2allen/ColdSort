//-----------------------------------------------------------------------
// <copyright file="ISongFile.cs" company="None">
//     Copyright (c) 2016 Christopher James Allen
// </copyright>
// <author>Christopher James Allen</author>
//-----------------------------------------------------------------------

namespace ColdSort.Core.Interfaces.Models
{
    /// <summary>
    /// Song file interface
    /// </summary>
    public interface ISongFile
    {
        /// <summary>
        /// Gets or sets a value of the title
        /// </summary>
        string Title { get; set; }

        /// <summary>
        /// Gets or sets a value of the artist
        /// </summary>
        string Artist { get; set; }

        /// <summary>
        /// Gets or sets a value of the album
        /// </summary>
        string Album { get; set; }

        /// <summary>
        /// Gets or sets a value of the year
        /// </summary>
        string Year { get; set; }

        /// <summary>
        /// Gets or sets a value of the original path of the song file
        /// </summary>
        string OriginalPath { get; set; }

        /// <summary>
        /// Gets or sets the value of the sorted path of the song file
        /// </summary>
        string SortedPath { get; set; }

        /// <summary>
        /// Gets a value of the original filename of the song file
        /// </summary>
        string OriginalFilename { get; }

        /// <summary>
        /// Gets value of the sorted filename of the song file
        /// </summary>
        /// <remarks>Not implemented fully yet </remarks>
        string SortedFilename { get; }

        /// <summary>
        /// Loads the song information from the song file
        /// </summary>
        /// <param name="path"> Path to the song file </param>
        /// <returns> If it was successful in loading song information</returns>
        bool LoadSongInformation(string path);
    }
}