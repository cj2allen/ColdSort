﻿//-----------------------------------------------------------------------
// <copyright file="ISortationService.cs" company="None">
//     Copyright (c) 2016 Christopher James Allen
// </copyright>
// <author>Christopher James Allen</author>
//-----------------------------------------------------------------------

using ColdSort.Core.Interfaces.Models;
using System.Collections.Generic;

namespace ColdSort.Interfaces.Controllers
{
    /// <summary>
    /// Sortation controller interface
    /// </summary>
    public interface ISortationService
    {
        /// <summary>
        /// Sorts the music in the original folder path to the new folder path using the given sortation schema. No diagnostics are collected.
        /// </summary>
        void SortWithoutDiagnostics();

        /// <summary>
        /// Cancels the sortation
        /// </summary>
        void CancelSort();

        /// <summary>
        /// Take a path to a valid music file and converts it to an SongFile
        /// </summary>
        /// <param name="songFilePath"> The path to a song file </param>
        /// <returns> The music file information </returns>
        SongFile ConvertPathToSongFile(string songFilePath);

        /// <summary>
        /// Attempts to generate sort path for a list of SongFile 
        /// </summary>
        /// <param name="songFiles"> A list of music files to be sorted </param>
        /// <returns> A list of results of the sort </returns>
        List<SortPathingResult> GenerateSortationPaths(List<SongFile> songFiles);
    }
}