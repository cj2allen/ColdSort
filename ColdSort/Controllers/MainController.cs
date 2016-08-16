//-----------------------------------------------------------------------
// <copyright file="MainController.cs" company="None">
//     Copyright (c) 2016 Christopher James Allen
// </copyright>
// <author>Christopher James Allen</author>
//-----------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ColdSort.Core.Enums;
using ColdSort.Core.Interfaces.Controllers;
using ColdSort.Core.Interfaces.Models;
using ColdSort.Models;
using ColdSort.Views;

namespace ColdSort.Controllers
{
    /// <summary>
    /// Manage main view functionality
    /// </summary>
    public class MainController : IMainController
    {
        #region Fields

        /// <summary>
        /// The main view form
        /// </summary>
        private MainView _mainView;

        /// <summary>
        /// The current sortation schema being used
        /// </summary>
        private ISortationSchema _sortationSchema;

        #endregion

        #region Contructor

        /// <summary>
        /// Initializes a new instance of the <see cref="MainController"/> class
        /// </summary>
        /// <param name="mainView"> The main view form </param>
        public MainController(MainView mainView)
        {
            _mainView = mainView;
            _mainView.SetController(this);
        }

        #endregion

        #region Delegates

        /// <summary>
        /// Delegate for setting the progress bar
        /// </summary>
        /// <param name="percentage"> Current percentage </param>
        private delegate void SetProgressCountInvoke(int percentage);

        /// <summary>
        /// Delegate for setting the progress percentage
        /// </summary>
        /// <param name="percentage"> Current file count </param>
        private delegate void SetFileCountInvoke(int percentage);

        #endregion

        #region Methods

        /// <summary>
        /// Load the main view with data
        /// </summary>
        /// <param name="loadDefaults"> Load the default sortation schema or not </param>
        public void SetupView(bool loadDefaults)
        {
            if (loadDefaults)
            {
                LoadDefaults();
            }

            _mainView.SchemaTitle = _sortationSchema.SortationSchemaTitle;
            _mainView.OriginalLocation = Environment.GetFolderPath(Environment.SpecialFolder.MyMusic);
            _mainView.DestinationLocation = @"D:\TestOutput";
            _mainView.Visible = true;
        }

        /// <summary>
        /// Load the default sortation schema
        /// </summary>
        public void LoadDefaults()
        {
            _sortationSchema = new SortationSchema();
            _sortationSchema.SortationSchemaTitle = "Default Sort";
            _sortationSchema.KeepFilesAtOriginalLocation = false;
            _sortationSchema.FailedSortationDefault = "!Unsorted";
            _sortationSchema.CopySongs = true;
            _sortationSchema.SortationNodes = new List<ISortationNode>
            {
                new SortationNode
                {
                    SongProperty = SongProperty.Artist,
                    AllowSortEnd = false,
                    UseAbbreviation = true,
                    CondenseNumbersToSymbol = true,
                    CapitalizeAbbreviation = true,
                    CondenseAccents = true,
                    CondenseSymbols = true
                },
                new SortationNode
                {
                    SongProperty = SongProperty.Artist,
                    AllowSortEnd = false,
                    UseAbbreviation = false,
                    CondenseNumbersToSymbol = false,
                    CapitalizeAbbreviation = false,
                    CondenseAccents = false,
                    CondenseSymbols = false
                },
                new SortationNode
                {
                    SongProperty = SongProperty.Album,
                    AllowSortEnd = true,
                    UseAbbreviation = false,
                    CondenseNumbersToSymbol = false,
                    CapitalizeAbbreviation = false,
                    CondenseAccents = false,
                    CondenseSymbols = false
                }
            };
        }

        /// <summary>
        /// Prompts user with a window to change a folder path
        /// </summary>
        /// <param name="currentPath"> The current set folder path </param>
        /// <returns>A folder path</returns>
        public string SelectFolder(string currentPath)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            DialogResult folderResult = folderBrowserDialog.ShowDialog();

            if (folderResult != DialogResult.OK)
            {
                _mainView.ErrorBox("Folder path is invalid. Path unchanged.");
                return currentPath;
            }
            
            return folderBrowserDialog.SelectedPath;
        }

        /// <summary>
        /// Creates an empty sortation schema and send it to be edited
        /// </summary>
        public void CreateSchema()
        {
            _sortationSchema = new SortationSchema();
            EditSchema(_sortationSchema);
        }

        /// <summary>
        /// Edits the current sortation schema in the controller
        /// </summary>
        public void EditSchema()
        {
            EditSchema(_sortationSchema);
            SetupView(false);
        }

        /// <summary>
        /// Edits a sortation schema in the controller
        /// </summary>
        /// <param name="sortationSchema"> A sortation schema</param>
        public void EditSchema(ISortationSchema sortationSchema)
        {
            using (SortationSchemaView sortationSchemaView = new SortationSchemaView())
            {
                ISortationSchemaController sortationSchemaController = new SortationSchemaController(sortationSchemaView, _sortationSchema);
                sortationSchemaController.SetupView();
                _sortationSchema = sortationSchemaController.GetSortationSchema();
            } 
        }

        /// <summary>
        /// Sort  music without any diagnostic information
        /// </summary>
        public void SortWithoutDiagnostics()
        {
            ISortationService SortationService = new SortationService(_mainView, _sortationSchema, _mainView.OriginalLocation, _mainView.DestinationLocation);
            SortationService.SortWithoutDiagnostics();         
        }

        #endregion
    }
}
