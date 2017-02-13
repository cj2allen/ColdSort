//-----------------------------------------------------------------------
// <copyright file="SongProperty.cs" company="None">
//     Copyright (c) 2016 Christopher James Allen
// </copyright>
// <author>Christopher James Allen</author>
//-----------------------------------------------------------------------

namespace ColdSort.Enums
{
    /// <summary>
    /// All valid song properties to sort
    /// </summary>
    public enum SongProperty
    {
        /// <summary>
        /// Song title
        /// </summary>
        Title = 0,

        /// <summary>
        /// Song's primary artist
        /// </summary>
        Artist = 1,

        /// <summary>
        /// All contributing artists
        /// </summary>
        Artists = 2,

        /// <summary>
        /// Song album
        /// </summary>
        Album = 3,

        /// <summary>
        /// Song year
        /// </summary>
        Year = 4,

        /// <summary>
        /// Song genre
        /// </summary>
        Genre = 5,

        /// <summary>
        /// Song disc number
        /// </summary>
        Disc = 6,

        /// <summary>
        /// Song bitrate
        /// </summary>
        Bitrate = 7
    }
}