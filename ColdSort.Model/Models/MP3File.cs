using ColdSort.Core.Interfaces.Models;
using System.Linq;

namespace ColdSort.Model.Models
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
        }

        public string OriginalFilename
        {
            get
            {
                if (_originalPath != null)
                {
                    return _originalPath.Split('\\').Last();
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
                    return _sortedPath.Split('\\').Last();
                }
                
                return "";
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
                _artist = tagFile.Tag.AlbumArtists.ToString();
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
