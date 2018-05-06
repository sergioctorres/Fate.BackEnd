using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;

namespace Fate.BackEnd.Application.AutoMapper
{
    public class AutoMapperConfig
    {
        public static void RegisterMappings()
        {
            Mapper.Initialize(i =>
            {
                i.AddProfile<DomainToViewModelMappingProfile>();
            });
        }
    }
}
