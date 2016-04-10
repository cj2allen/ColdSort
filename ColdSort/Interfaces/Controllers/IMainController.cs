namespace ColdSort.Core.Interfaces.Controllers
{
    public interface IMainController
    {
        void LoadView();

        void LoadDefaults();

        string SelectFolder(string originalPath);
    }
}