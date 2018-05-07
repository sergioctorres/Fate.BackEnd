using Fate.BackEnd.Domain.Models;

namespace Fate.BackEnd.Domain.Interfaces
{
    public interface ICustomerRepository : IRepository<Customer>, IRepositoryWrite<Customer>
    {
    }
}
