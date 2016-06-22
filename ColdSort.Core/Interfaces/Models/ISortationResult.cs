//-----------------------------------------------------------------------
// <copyright file="ISortationResult.cs" company="None">
//     Copyright (c) 2016 Christopher James Allen
// </copyright>
// <author>Christopher James Allen</author>
//-----------------------------------------------------------------------

namespace ColdSort.Core.Interfaces.Models
{
    /// <summary>
    /// Sortation result interface
    /// </summary>
    public interface ISortationResult
    {
        /// <summary>
        /// Gets or sets the error message from the sortation
        /// </summary>
        string ErrorMessage { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the song file was sorted
        /// </summary>
        bool IsSorted { get; set; }

        /// <summary>
        /// Gets or sets the original song file location
        /// </summary>
        string OriginalPath { get; set; }

        /// <summary>
        /// Gets or sets the new sorted location of the song file
        /// </summary>
        string SortedPath { get; set; }
    }
}
