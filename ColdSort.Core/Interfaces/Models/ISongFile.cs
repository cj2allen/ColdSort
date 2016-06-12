namespace ColdSort.Core.Interfaces.Models
{
    public interface ISongFile
    {
        #region Properties
        string Title { get; }
        string Artist { get; }
        string Album { get; }
        string Year { get; }        
        string OriginalPath { get; }
        string SortedPath { get; set; }
        string OriginalFilename { get; }
        string SortedFilename { get; }
        #endregion

        #region Methods
        bool LoadSongInformation(string path);
        #endregion

    }
}