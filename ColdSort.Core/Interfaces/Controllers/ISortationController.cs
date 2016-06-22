//-----------------------------------------------------------------------
// <copyright file="ISortationController.cs" company="None">
//     Copyright (c) 2016 Christopher James Allen
// </copyright>
// <author>Christopher James Allen</author>
//-----------------------------------------------------------------------

namespace ColdSort.Core.Interfaces.Controllers
{
    /// <summary>
    /// Sortation controller interface
    /// </summary>
    public interface ISortationController
    {
        /// <summary>
        /// Sorts the music in the original folder path to the new folder path using the given sortation schema. No diagnostics are collected.
        /// </summary>
        /// <param name="oldRootpath"> The original folder path </param>
        /// <param name="newRootPath"> The destination folder path </param>
        void SortWithoutDiagnostics(string oldRootpath, string newRootPath);

        /// <summary>
        /// Cancels the sortation
        /// </summary>
        void CancelSort();
    }
}