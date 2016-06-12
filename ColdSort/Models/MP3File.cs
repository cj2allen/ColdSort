using ColdSort.Core.Interfaces.Models;
using System;
using System.IO;
using System.Linq;

namespace ColdSort.Models
{
    public class MP3File : ISongFile
    {
        #region Properties
        public string Title
        {
            get
            {
                return _title;
            }
        }

        public string Artist
        {
            get
            {
                return _artist;
            }
        }

        public string Album
        {
            get
            {
                return _album;
            }
        }

        public string Year
        {
            get
            {
                return _year;
            }
        }

        public string OriginalPath
        {
            get
            {
                return _originalPath;
            }
        }

        public string SortedPath
        {
            get
            {
                return _sortedPath;
            }
            set
            {
                _sortedPath = value;
            }
        }

        public string OriginalFilename
        {
            get
            {
                if (_originalPath != null)
                {
                    return Path.GetFileName(_originalPath);
                }

                return "";
            }
        }

        public string SortedFilename
        {
            get
            {
                if(_sortedPath != null)
                {
                    return Path.GetFileName(_sortedPath);
                }
                
                return "";
            }
            set
            {
                _sortedPath = value;
            }
        }
        #endregion

        #region Field
        private string _title = "";
        private string _artist = "";
        private string _album = "";
        private string _year = "";
        private string _originalPath = "";
        private string _sortedPath = "";

        #endregion

        #region Methods
        public bool LoadSongInformation(string path)
        {
            _originalPath = path;

            try
            {
                TagLib.File tagFile = TagLib.File.Create(path);
                _title = tagFile.Tag.Title;
                _artist = String.Join(", ", tagFile.Tag.AlbumArtists);
                _album = tagFile.Tag.Album;
                _year = tagFile.Tag.Year.ToString();

                return true;
            }
            catch
            {
                return false;
            }
        }
        #endregion
    }
}
