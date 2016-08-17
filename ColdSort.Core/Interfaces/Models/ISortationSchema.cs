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
        /// <see cref="ISortationSchema.SortationSchemaTitle"/>
        /// </summary>
        string SortationSchemaTitle { get; set; }

        /// <summary>
        /// <see cref="ISortationSchema.FailedSortationDefault"/>
        /// </summary>
        string FailedSortationDefault { get; set; }

        /// <summary>
        /// <see cref="ISortationSchema.SortationNodes"/>
        /// </summary>
        List<ISortationNode> SortationNodes { get; set; }

        /// <summary>
        /// <see cref="ISortationSchema.KeepFilesAtOriginalLocation"/>
        /// </summary>
        bool KeepFilesAtOriginalLocation { get; set; }

        /// <summary>
        /// <see cref="ISortationSchema.CopySongs"/>
        /// </summary>
        bool CopySongs { get; set; }

        /// <summary>
        /// <see cref="ISortationSchema.FixIllegalCharacters"/>
        /// </summary>
        bool FixIllegalCharacters { get; set; }
    }
}