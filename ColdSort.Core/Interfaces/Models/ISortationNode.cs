//-----------------------------------------------------------------------
// <copyright file="ISortationNode.cs" company="None">
//     Copyright (c) 2016 Christopher James Allen
// </copyright>
// <author>Christopher James Allen</author>
//-----------------------------------------------------------------------

using ColdSort.Core.Enums;

namespace ColdSort.Core.Interfaces.Models
{
    /// <summary>
    /// The sortation node interface
    /// </summary>
    public interface ISortationNode
    {
        /// <summary>
        /// Gets the sortation node name
        /// </summary>
        string Name { get; }

        /// <summary>
        /// Gets or sets the sortation node song's property
        /// </summary>
        SongProperty SongProperty { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the sort of a song can end at this node
        /// </summary>
        bool AllowSortEnd { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the folder created with this node uses an abbreviation
        /// </summary>
        bool UseAbbreviation { get; set; }

        /// <summary>
        /// Returns the sortation node's property as a string
        /// </summary>
        /// <returns> The song's sortation property as a string </returns>
        string GetSortationNodeProperty();
    }
}