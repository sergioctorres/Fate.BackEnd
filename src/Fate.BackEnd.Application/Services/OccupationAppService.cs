using AutoMapper;
using Fate.BackEnd.Application.Interfaces;
using Fate.BackEnd.Application.ViewModels;
using Fate.BackEnd.Domain.Interfaces;
using Fate.BackEnd.Domain.Models;
using System.Collections.Generic;

namespace Fate.BackEnd.Application.Services
{
    public class OccupationAppService : IOccupationAppService
    {
        private readonly IOccupationRepository _occupationRepository;

        public OccupationAppService(IOccupationRepository occupationRepository)
        {
            _occupationRepository = occupationRepository;
        }

        public OccupationViewModel Add(OccupationViewModel occupationViewModel)
        {
            var occupation = Mapper.Map<Occupation>(occupationViewModel);

            var occupationRet = _occupationRepository.Add(occupation);

            return occupationViewModel;
        }

        public void Delete(int id)
        {
            _occupationRepository.Delete(id);
        }

        public void Dispose()
        {
            _occupationRepository.Dispose();
        }

        public IEnumerable<OccupationViewModel> GetAll()
        {
            return Mapper.Map<IEnumerable<OccupationViewModel>>(_occupationRepository.GetAll());
        }

        public OccupationViewModel GetById(int id)
        {
            return Mapper.Map<OccupationViewModel>(_occupationRepository.GetById(id));
        }

        public OccupationViewModel Update(OccupationViewModel occupationViewModel)
        {
            var occupation = Mapper.Map<Occupation>(occupationViewModel);

            _occupationRepository.Update(occupation);

            return occupationViewModel;
        }
    }
}
