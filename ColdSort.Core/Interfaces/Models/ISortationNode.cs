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
        string SortationNodeName { get; }

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
        /// Gets or sets a value indicating whether to condense all number abbreviations into the folder #
        /// </summary>
        bool CondenseNumbersToSymbol { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether to condense all number abbreviations into the folder #
        /// </summary>
        bool CapitalizeAbbreviation { get; set; }

        /// <summary>
        /// Returns the sortation node's property as a string
        /// </summary>
        /// <returns> The song's sortation property as a string </returns>
        string GetSortationNodeProperty();

        /// <summary>
        /// Gets or sets a value indicating whether to condense accented characters to 26 character ascii
        /// </summary>
        bool CondenseAccents { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether to condense abbreviation symbols into one folder
        /// </summary>
        bool CondenseSymbols { get; set; }
    }
}