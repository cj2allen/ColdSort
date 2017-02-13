//-----------------------------------------------------------------------
// <copyright file="SortationNodeController.cs" company="None">
//     Copyright (c) 2016 Christopher James Allen
// </copyright>
// <author>Christopher James Allen</author>
//-----------------------------------------------------------------------

using ColdSort.Models;

namespace ColdSort.Interfaces.Controllers
{
    /// <summary>
    /// Sortation node interface
    /// </summary>
    public interface ISortationNodeController
    {
        /// <summary>
        /// The current sortation node being used
        /// </summary>
        void SetupView();

        /// <summary>
        /// Update settings to current settings
        /// </summary>
        void Confirm();

        /// <summary>
        /// Keep original settings and discard changes
        /// </summary>
        void Cancel();

        /// <summary>
        /// Returns the current sortation node
        /// </summary>
        /// <returns> The sortation node </returns>
        SortationNode GetSortationNode();

        /// <summary>
        /// Cleans up view
        /// </summary>
        void UnloadView();
    }
}