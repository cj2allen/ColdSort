//-----------------------------------------------------------------------
// <copyright file="FailedSortation.cs" company="None">
//     Copyright (c) 2016 Christopher James Allen
// </copyright>
// <author>Christopher James Allen</author>
//-----------------------------------------------------------------------

namespace ColdSort.Models
{
    /// <summary>
    /// Information related to a failed sortation
    /// </summary>
    public class MoveCopyResult
    {
        #region Fields

        /// <summary>
        /// <see cref="SortationPathingResult.OriginalPath"/>
        /// </summary>
        public string OriginalPath { get; set; }

        /// <summary>
        /// <see cref="SortationPathingResult.SortedPath"/>
        /// </summary>
        public string SortedPath { get; set; }

        /// <summary>
        /// Gets or sets the reason the song file could not be sorted
        /// </summary>
        public string ErrorMessage { get; set; }

        public bool Successful
        {
            get
            {
                return string.IsNullOrEmpty(ErrorMessage);
            }
        }

        #endregion
    }
}
