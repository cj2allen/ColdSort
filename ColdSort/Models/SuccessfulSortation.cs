//-----------------------------------------------------------------------
// <copyright file="SuccessfulSortation.cs" company="None">
//     Copyright (c) 2016 Christopher James Allen
// </copyright>
// <author>Christopher James Allen</author>
//-----------------------------------------------------------------------

using ColdSort.Core.Interfaces.Models;

namespace ColdSort.Models
{
    /// <summary>
    /// Information related to a successful sortation
    /// </summary>
    public class SuccessfulSortation : ISortationSchemaResult
    {
        /// <summary>
        /// <see cref="ISortationSchemaResult.OriginalPath"/>
        /// </summary>
        public string OriginalPath { get; set; }

        /// <summary>
        /// <see cref="ISortationSchemaResult.SortedPath"/>
        /// </summary>
        public string SortedPath { get; set; }
    }
}