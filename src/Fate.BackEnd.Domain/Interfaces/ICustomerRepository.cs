using Fate.BackEnd.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fate.BackEnd.Domain.Interfaces
{
    public interface ICustomerRepository : IRepository<Customer>, IRepositoryWrite<Customer>
    {
    }
}
