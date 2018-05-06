using Fate.BackEnd.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fate.BackEnd.Application.Interfaces
{
    public interface ICustomerAppService : IDisposable
    {
        CustomerViewModel Add(CustomerViewModel customerViewModel);
        CustomerViewModel GetById(int id);
        IEnumerable<CustomerViewModel> GetAll();
        CustomerViewModel Update(CustomerViewModel customerViewModel);
        void Delete(int id);
    }
}
