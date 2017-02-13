using ColdSort.Core.Interfaces.Controllers;

namespace ColdSort.Core.Interfaces.Views
{
    public interface ISortationSchemaView
    {
        string FailedDefaultLocation { get; set; }
        bool KeepFilesAtOriginalLocation { get; set; }
        string SchemaName { get; set; }
        bool UseFailedDefaultLocation { get; set; }

        void SetController(ISortationSchemaController sortationSchemaController);
    }
}
