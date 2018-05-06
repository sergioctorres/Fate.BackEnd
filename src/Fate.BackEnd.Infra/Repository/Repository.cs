using Fate.BackEnd.Domain.Interfaces;
using Fate.BackEnd.Domain.Models;
using Fate.BackEnd.Infra.Context;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace Fate.BackEnd.Infra.Repository
{
    public abstract class Repository<TEntity> : IRepository<TEntity>, IRepositoryWrite<TEntity> where TEntity : Entity, new()
    {
        protected InfraContext Db;
        protected DbSet<TEntity> DbSet;

        protected Repository()
        {
            Db = new InfraContext();
            DbSet = Db.Set<TEntity>();
        }

        public virtual TEntity Add(TEntity obj)
        {
            var objRet = DbSet.Add(obj);
            SaveChanges();
            return objRet;
        }

        public virtual TEntity Update(TEntity obj)
        {
            var entry = Db.Entry(obj);
            DbSet.Attach(obj);
            entry.State = EntityState.Modified;
            SaveChanges();
            return obj;
        }

        public virtual void Delete(int id)
        {
            var customer = Db.Customers.Find(id);

            var entry = Db.Entry(customer);
            entry.State = EntityState.Deleted;
            
            SaveChanges();
        }

        public int SaveChanges()
        {
            return Db.SaveChanges();
        }

        public virtual TEntity GetById(int id)
        {
            return DbSet.Find(id);
        }

        public virtual IEnumerable<TEntity> GetAll()
        {
            return DbSet.ToList();
        }

        public void Dispose()
        {
            Db.Dispose();
        }
    }
}
