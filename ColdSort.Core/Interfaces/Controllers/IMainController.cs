using ColdSort.Core.Interfaces.Models;
using System;

namespace ColdSort.Core.Interfaces.Controllers
{
    public interface IMainController
    {
        void LoadView();

        void LoadDefaults();

        string SelectFolder(string originalPath);
        void CreateSchema();
        void EditSchema(ISortationSchema sortationSchema);
        void EditSchema();
        void SortWithoutDiagnostics();
    }
}