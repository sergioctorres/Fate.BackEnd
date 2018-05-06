using Fate.BackEnd.Infra.Context;

namespace Fate.BackEnd.Infra.UoW
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly InfraContext _context;

        public UnitOfWork(InfraContext context)
        {
            _context = context;
        }

        public int Commit()
        {
            return _context.SaveChanges();
        }
    }
}
