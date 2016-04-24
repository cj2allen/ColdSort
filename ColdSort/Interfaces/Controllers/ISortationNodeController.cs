﻿using ColdSort.Core.Interfaces.Models;

namespace ColdSort.Core.Interfaces.Controllers
{
    public interface ISortationNodeController
    {
        void LoadView();

        void Save();

        void Cancel();

        ISortationNode GetSortationNode();

        void UnloadView();
    }
}