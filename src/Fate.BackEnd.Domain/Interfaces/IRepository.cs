using Fate.BackEnd.Domain.Models;
using System;
using System.Collections.Generic;

namespace Fate.BackEnd.Domain.Interfaces
{
    public interface IRepository<TEntity> : IDisposable where TEntity : Entity
    {
        TEntity GetById(int id);

        IEnumerable<TEntity> GetAll();
    }
}
