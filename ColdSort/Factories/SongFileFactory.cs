using ATL;
using ColdSort.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColdSort.Factories
{
    public static class SongFileFactory
    {
        #region Methods

        /// <summary>
        /// Creates a SongFile based on the files metadata
        /// </summary>
        /// <param name="path"> Path to the song file </param>
        /// <returns> If it was successful in loading song information</returns>
        public static SongFile Create(string path)
        {
            Track track;

            try
            {
                track = new Track(path);
            }
            catch
            {
                return null;
            }

            return new SongFile
            {
                OriginalPath = path ?? "",
                Title = track.Title ?? "",
                Artist = track.Artist.Split('/')[0] ?? "",
                Artists = track.Artist ?? "",
                Album = track.Album ?? "",
                Year = track.Year.ToString(),
                Genre = track.Genre ?? "",
                Disc = track.DiscNumber.ToString(),
                Bitrate = track.Bitrate.ToString()
            };
        }

        #endregion
    }
}
