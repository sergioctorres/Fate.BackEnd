using Fate.BackEnd.Application.ViewModels;
using System;
using System.Collections.Generic;

namespace Fate.BackEnd.Application.Interfaces
{
    public interface IOccupationAppService : IDisposable
    {
        OccupationViewModel Add(OccupationViewModel occupationViewModel);
        OccupationViewModel GetById(int id);
        IEnumerable<OccupationViewModel> GetAll();
        OccupationViewModel Update(OccupationViewModel occupationViewModel);
        void Delete(int id);
    }
}
