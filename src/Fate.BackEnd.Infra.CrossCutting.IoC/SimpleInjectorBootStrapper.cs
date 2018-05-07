using Fate.BackEnd.Application.Interfaces;
using Fate.BackEnd.Application.Services;
using Fate.BackEnd.Domain.Interfaces;
using Fate.BackEnd.Infra.Context;
using Fate.BackEnd.Infra.Repository;
using Fate.BackEnd.Infra.UoW;
using SimpleInjector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fate.BackEnd.Infra.CrossCutting.IoC
{
    public class SimpleInjectorBootStrapper
    {
        public static void Register(Container container)
        {
            // Lifestyle.Transient => Uma instancia para cada solicitacao;
            // Lifestyle.Singleton => Uma instancia unica para a classe (para o servidor)
            // Lifestyle.Scoped => Uma instancia unica para o request

            // App
            container.Register<ICustomerAppService, CustomerAppService>(Lifestyle.Scoped);
            container.Register<IOccupationAppService, OccupationAppService>(Lifestyle.Scoped);

            // Data
            container.Register<ICustomerRepository, CustomerRepository>(Lifestyle.Scoped);
            container.Register<IOccupationRepository, OccupationRepository>(Lifestyle.Scoped);
            container.Register<IUnitOfWork, UnitOfWork>(Lifestyle.Scoped);
            container.Register<InfraContext>(Lifestyle.Scoped);
        }
    }
}
