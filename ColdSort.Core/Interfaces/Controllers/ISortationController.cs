using ColdSort.Core.Interfaces.Models;

namespace ColdSort.Core.Interfaces.Controllers
{
    public interface ISortationController
    {
        void SortWithoutDiagnostics(string originalLocation, string destinationLocation, ISortationSchema _sortationSchema);
        string CombineExtensions();

    }
}