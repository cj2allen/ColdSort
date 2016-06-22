//-----------------------------------------------------------------------
// <copyright file="ISortationSchemaController.cs" company="None">
//     Copyright (c) 2016 Christopher James Allen
// </copyright>
// <author>Christopher James Allen</author>
//-----------------------------------------------------------------------

using System.Collections.Generic;
using ColdSort.Core.Interfaces.Models;

namespace ColdSort.Core.Interfaces.Controllers
{
    /// <summary>
    /// Sortation schema controller interface
    /// </summary>
    public interface ISortationSchemaController
    {
        /// <summary>
        /// Load the sortation schema view with data
        /// </summary>
        void SetupView();

        /// <summary>
        /// Raises the node at the selected index up an element
        /// </summary>
        /// <param name="index"> The current position of the element that is to be raised </param>
        /// <returns> A list of the updated position of sortation nodes</returns>
        List<ISortationNode> RaiseNode(int index);

        /// <summary>
        /// Lower the node sortation at the selected index down an element
        /// </summary>
        /// <param name="index"> The current position of the element that is to be lowered </param>
        /// <returns> A list of the updated position of sortation nodes</returns>
        List<ISortationNode> LowerNode(int index);

        /// <summary>
        /// Removes the sortation node at the selected index
        /// </summary>
        /// <param name="index"> The current position of the element that is to be removed </param>
        /// <returns> An updated list of sortation nodes</returns>
        List<ISortationNode> RemoveNode(int index);

        /// <summary>
        /// Adds a sortation node to a sortation schema
        /// </summary>        
        /// <returns> An updated list of sortation nodes</returns>
        List<ISortationNode> CreateSortationNode();

        /// <summary>
        /// Edits the sortation node at the selected index
        /// </summary>
        /// <param name="index"> The current position of the element that is to be edited </param>
        /// <returns> An updated list of sortation nodes</returns>
        List<ISortationNode> EditSortationNode(int index);

        /// <summary>
        /// Returns the current sortation schema
        /// </summary>
        /// <returns> The sortation node </returns>
        ISortationSchema GetSortationSchema();

        /// <summary>
        /// Updates the sortation schema with the current data
        /// </summary>
        void SaveSchema();

        /// <summary>
        /// Keep original settings and discard changes
        /// </summary>
        void CancelSchema();
    }
}