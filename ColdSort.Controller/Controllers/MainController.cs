using System;
using System.Collections.Generic;
using ColdSort.Model.Models;
using ColdSort.Core.Enums;
using System.Windows.Forms;
using ColdSort.Core.Interfaces.Models;
using ColdSort.Core.Interfaces.Controllers;
using ColdSort.Core.Interfaces.Views;

namespace ColdSort.Controller.Controllers
{
    public class MainController : IMainController
    {
        private IMainView _mainView;
        private ISortationSchema _sortationSchema;

        public MainController(IMainView mainView)
        {
            _mainView = mainView;
            _mainView.SetController(this);
        }

        public void LoadView()
        {
            LoadDefaults();
        }

        public void LoadDefaults()
        {
            _mainView.OriginalLocation = Environment.GetFolderPath(Environment.SpecialFolder.MyMusic);
            _mainView.DestinationLocation = _mainView.OriginalLocation;
            _sortationSchema = new SortationSchema();
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
    }
}
