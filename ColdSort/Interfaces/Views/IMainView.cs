using ColdSort.Core.Interfaces.Controllers;

namespace ColdSort.Core.Interfaces.Views
{
    public interface IMainView
    {
        string OriginalLocation { get; set; }
        string DestinationLocation { get; set; }
        bool Visible { get; set; }

        void SetController(IMainController mainController);
        void ErrorBox(string message);
    }
}
