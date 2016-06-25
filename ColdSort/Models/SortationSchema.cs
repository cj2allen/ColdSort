//-----------------------------------------------------------------------
// <copyright file="SortationSchema.cs" company="None">
//     Copyright (c) 2016 Christopher James Allen
// </copyright>
// <author>Christopher James Allen</author>
//-----------------------------------------------------------------------

using System;
using System.Collections.Generic;
using ColdSort.Core.Interfaces.Models;

namespace ColdSort.Models
{
    /// <summary>
    /// The sortation schema
    /// </summary>
    public class SortationSchema : ISortationSchema
    {
        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="SortationSchema"/> class
        /// </summary>
        public SortationSchema()
        {
            SortationNodes = new List<ISortationNode>();
            FailedSortationDefault = "!Unsorted";
        }

        #endregion

        #region Properties

        /// <summary>
        /// Gets or sets the sortation schema title
        /// </summary>
        public string SortationSchemaTitle { get; set; }

        /// <summary>
        /// Gets or sets the sortation schema sortation path for file that fail sortation
        /// </summary>
        public string FailedSortationDefault { get; set; }

        /// <summary>
        /// Gets or sets the sortation nodes
        /// </summary>
        public List<ISortationNode> SortationNodes { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether to keep files in the original location or to move them to the default folder
        /// </summary>
        public bool KeepFilesAtOriginalLocation { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the files will be copied or moved to the new destination
        /// </summary>
        public bool CopySongs { get; set; }

        #endregion
    }
}
