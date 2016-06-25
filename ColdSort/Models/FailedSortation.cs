﻿//-----------------------------------------------------------------------
// <copyright file="FailedSortation.cs" company="None">
//     Copyright (c) 2016 Christopher James Allen
// </copyright>
// <author>Christopher James Allen</author>
//-----------------------------------------------------------------------

using ColdSort.Core.Interfaces.Models;

namespace ColdSort.Models
{
    /// <summary>
    /// Information related to a failed sortation
    /// </summary>
    public class FailedSortation : ISortationSchemaResult
    {
        #region Fields

        /// <summary>
        /// Gets or sets the original location of the song file
        /// </summary>
        public string OriginalPath { get; set; }

        /// <summary>
        /// Gets or sets the reason the song file could not be sorted
        /// </summary>
        public string ErrorMessage { get; set; }

        #endregion
    }
}