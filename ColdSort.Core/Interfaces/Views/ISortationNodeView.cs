using ColdSort.Core.Interfaces.Controllers;

namespace ColdSort.Core.Interfaces.Views
{
    public interface ISortationNodeView
    {
        bool AllowSortEnd { get; set; }
        string NodeName { get; set; }
        int Property { get; set; }
        bool UseAbbreviation { get; set; }
        bool Visible { get; set; }

        void SetController(ISortationNodeController sortationNodeController);
        void Hide();
    }
}
