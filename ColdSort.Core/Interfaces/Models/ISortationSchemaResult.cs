//-----------------------------------------------------------------------
// <copyright file="ISortationSchemaResult.cs" company="None">
//     Copyright (c) 2016 Christopher James Allen
// </copyright>
// <author>Christopher James Allen</author>
//-----------------------------------------------------------------------

namespace ColdSort.Core.Interfaces.Models
{
    /// <summary>
    /// Sortation Schema Result Interface
    /// </summary>
    public interface ISortationSchemaResult
    {
        /// <summary>
        /// Gets or sets the original location of the song file
        /// </summary>
        string OriginalPath { get; set; }

        /// <summary>
        /// Gets or sets the original location of the song file
        /// </summary>
        string SortedPath { get; set; }
    }
}