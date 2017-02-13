//-----------------------------------------------------------------------
// <copyright file="IMainController.cs" company="None">
//     Copyright (c) 2016 Christopher James Allen
// </copyright>
// <author>Christopher James Allen</author>
//-----------------------------------------------------------------------

using ColdSort.Models;

namespace ColdSort.Interfaces.Controllers
{
    /// <summary>
    /// Main controller interface
    /// </summary>
    public interface IMainController
    {
        /// <summary>
        /// Load the main view with data
        /// </summary>
        /// <param name="loadDefaults"> Load the default sortation schema or not </param>
        void SetupView(bool loadDefaults);

        /// <summary>
        /// Load the default sortation schema into the 
        /// </summary>
        void LoadDefaults();

        /// <summary>
        /// Prompts user with a window to change a folder path
        /// </summary>
        /// <param name="currentPath"> The current set folder path </param>
        /// <returns>A folder path</returns>
        string SelectFolder(string currentPath);

        /// <summary>
        /// Creates an empty sortation schema and send it to be edited
        /// </summary>
        void CreateSchema();

        /// <summary>
        /// Edits a sortation schema in the controller
        /// </summary>
        /// <param name="sortationSchema"> A sortation schema</param>
        void EditSchema(SortationSchema sortationSchema);

        /// <summary>
        /// Edits the current sortation schema in the controller
        /// </summary>
        void EditSchema();

        /// <summary>
        /// Sort  music without any diagnostic information
        /// </summary>
        void SortWithoutDiagnostics();
    }
}