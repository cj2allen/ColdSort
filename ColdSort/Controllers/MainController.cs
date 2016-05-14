using System;
using System.Collections.Generic;
using ColdSort.Models;
using ColdSort.Core.Enums;
using System.Windows.Forms;
using ColdSort.Core.Interfaces.Models;
using ColdSort.Core.Interfaces.Controllers;
using ColdSort.Views;

namespace ColdSort.Controllers
{
    public class MainController : IMainController
    {
        private MainView _mainView;
        private ISortationSchema _sortationSchema;

        public MainController(MainView mainView)
        {
            _mainView = mainView;
            _mainView.SetController(this);
        }

        public void LoadView()
        {
            LoadDefaults();
            _mainView.Visible = true;
        }

        public void LoadDefaults()
        {
            _mainView.OriginalLocation = Environment.GetFolderPath(Environment.SpecialFolder.MyMusic);
            _mainView.DestinationLocation = _mainView.OriginalLocation;
            _sortationSchema = new SortationSchema();
            _sortationSchema.SortationSchemaTitle = "Default Sort";
            _sortationSchema.KeepFilesAtOriginalLocation = false;
            _sortationSchema.FailedSortationDefault = "!Unsorted";
            _sortationSchema.SortationNodes = new List<ISortationNode>
            {
                new SortationNode
                {
                    Name = "Artist Abbrv",
                    SongProperty = SongProperty.Artist,
                    AllowSortEnd = false,
                    UseAbbreviation = true
                },
                new SortationNode
                {
                    Name = "Artist Full",
                    SongProperty = SongProperty.Artist,
                    AllowSortEnd = false,
                    UseAbbreviation = false
                },
                new SortationNode
                {
                    Name = "Album Name",
                    SongProperty = SongProperty.Album,
                    AllowSortEnd = true,
                    UseAbbreviation = false
                }
            };
        }

        public string SelectFolder(string originalPath)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            DialogResult folderResult = folderBrowserDialog.ShowDialog();

            if (folderResult == DialogResult.OK)
            {
                return folderResult.ToString();
            }

            _mainView.ErrorBox("Folder path is invalid. Path unchanged.");

            return originalPath;
        }

        public void CreateSchema()
        {
            _sortationSchema = new SortationSchema();
            EditSchema(_sortationSchema);
        }

        public void EditSchema()
        {
            EditSchema(_sortationSchema);
        }

        public void EditSchema(ISortationSchema sortationSchema)
        {
            using ( SortationSchemaView sortationSchemaView = new SortationSchemaView())
            {
                ISortationSchemaController sortationSchemaController = new SortationSchemaController(sortationSchemaView);
                sortationSchemaController.LoadSchemaData(_sortationSchema);
                _sortationSchema = sortationSchemaController.GetSortationSchema();
            } 
        }

        public void CancelSort()
        {
            throw new NotImplementedException();
        }

        public void SortWithoutDiagnostics()
        {
            SortationService.SortWithNoDiagnostics(_mainView.OriginalLocation, _mainView.DestinationLocation, _sortationSchema);
        }
    }
}
