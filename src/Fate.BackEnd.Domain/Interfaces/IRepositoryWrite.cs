using Fate.BackEnd.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fate.BackEnd.Domain.Interfaces
{
    public interface IRepositoryWrite<TEntity> : IDisposable where TEntity : Entity
    {
        TEntity Add(TEntity obj);
        TEntity Update(TEntity obj);
        void Delete(int id);
        int SaveChanges();
    }
}
