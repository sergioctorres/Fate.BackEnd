using AutoMapper;
using Fate.BackEnd.Application.ViewModels;
using Fate.BackEnd.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
