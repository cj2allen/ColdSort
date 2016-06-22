//-----------------------------------------------------------------------
// <copyright file="ISortationSchema.cs" company="None">
//     Copyright (c) 2016 Christopher James Allen
// </copyright>
// <author>Christopher James Allen</author>
//-----------------------------------------------------------------------

using System.Collections.Generic;

namespace ColdSort.Core.Interfaces.Models
{
    /// <summary>
    /// Sortation schema interface
    /// </summary>
    public interface ISortationSchema
    {
        /// <summary>
        /// Gets or sets the sortation schema title
        /// </summary>
        string SortationSchemaTitle { get; set; }

        /// <summary>
        /// Gets or sets the sortation schema sortation path for file that fail sortation
        /// </summary>
        string FailedSortationDefault { get; set; }

        /// <summary>
        /// Gets or sets the sortation nodes
        /// </summary>
        List<ISortationNode> SortationNodes { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether to keep files in the original location or to move them to the default folder
        /// </summary>
        bool KeepFilesAtOriginalLocation { get; set; }
    }
}