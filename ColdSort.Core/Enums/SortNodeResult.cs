﻿//-----------------------------------------------------------------------
// <copyright file="SortNodeResult.cs" company="None">
//     Copyright (c) 2016 Christopher James Allen
// </copyright>
// <author>Christopher James Allen</author>
//-----------------------------------------------------------------------

namespace ColdSort.Core.Enums
{
    /// <summary>
    /// Possible results for sortation node outcome
    /// </summary>
    public enum SortNodeResult
    {
        /// <summary>
        /// Song file is not fully sorted
        /// </summary>
        NotSorted,

        /// <summary>
        /// Song file is sorted
        /// </summary>
        Sorted,

        /// <summary>
        /// There was an error in sortation
        /// </summary>
        Error
    }
}