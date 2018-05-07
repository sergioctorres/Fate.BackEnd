using Fate.BackEnd.Domain.Models;

namespace Fate.BackEnd.Domain.Interfaces
{
    public interface IOccupationRepository : IRepository<Occupation>, IRepositoryWrite<Occupation>
    {
    }
}
