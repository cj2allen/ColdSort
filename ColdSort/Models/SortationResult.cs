//-----------------------------------------------------------------------
// <copyright file="SortationResult.cs" company="None">
//     Copyright (c) 2016 Christopher James Allen
// </copyright>
// <author>Christopher James Allen</author>
//-----------------------------------------------------------------------

namespace ColdSort.Models
{
    /// <summary>
    /// Information related to a sortation result of a song file
    /// </summary>
    public class SortationResult
    {
        #region Fields

        /// <summary>
        /// Gets or sets the error message from the sortation
        /// </summary>
        public string ErrorMessage { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the song file was sorted
        /// </summary>
        public bool Successful
        {
            get
            {
                return string.IsNullOrEmpty(ErrorMessage);
            }
        }

        /// <summary>
        /// Gets or sets the original song file location
        /// </summary>
        public string OriginalPath { get; set; }

        /// <summary>
        /// Gets or sets the new sorted location of the song file
        /// </summary>
        public string SortedPath { get; set; }

        #endregion
    }
}
