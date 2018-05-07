using AutoMapper;
using Fate.BackEnd.Application.ViewModels;
using Fate.BackEnd.Domain.Models;

namespace Fate.BackEnd.Application.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {
            CreateMap<Customer, CustomerViewModel>();
            CreateMap<Occupation, OccupationViewModel>();
        }
    }
}
