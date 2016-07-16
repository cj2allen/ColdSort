//-----------------------------------------------------------------------
// <copyright file="SortationNode.cs" company="None">
//     Copyright (c) 2016 Christopher James Allen
// </copyright>
// <author>Christopher James Allen</author>
//-----------------------------------------------------------------------

using ColdSort.Core.Enums;
using ColdSort.Core.Interfaces.Models;

namespace ColdSort.Models
{
    /// <summary>
    /// The sortation node
    /// </summary>
    public class SortationNode : ISortationNode
    {
        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="SortationNode"/> class
        /// </summary>
        public SortationNode()
        {
            SongProperty = 0;
            AllowSortEnd = true;
            UseAbbreviation = false;
        }

        #endregion

        #region Properties

        /// <summary>
        /// Gets the sortation node name
        /// </summary>
        public string SortationNodeName
        {
            get
            {
                string abbrivation = UseAbbreviation ? ", Use Abbr." : string.Empty;
                string end = AllowSortEnd ? ", Can End" : string.Empty;
                return string.Format("{0}{1}{2}", SongProperty.ToString(), abbrivation, end);
            }
        }

        /// <summary>
        /// Gets or sets the sortation node song's property
        /// </summary>
        public SongProperty SongProperty { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the sort of a song can end at this node
        /// </summary>
        public bool AllowSortEnd { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the folder created with this node uses an abbreviation
        /// </summary>
        public bool UseAbbreviation { get; set; }

        #endregion

        #region Methods

        /// <summary>
        /// Returns the sortation node's property as a string
        /// </summary>
        /// <returns> The song's sortation property as a string </returns>
        public string GetSortationNodeProperty()
        {
            return SongProperty.ToString();
        }

        #endregion
    }
}