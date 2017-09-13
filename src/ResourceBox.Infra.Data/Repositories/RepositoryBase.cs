using ResourceBox.Domain.Interfaces.Repository;
using ResourceBox.Infra.Data.Context;
using System.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ResourceBox.Infra.Data.Repositories
{
    public class RepositoryBase<TEntity> : IRepositoryBase<TEntity> where TEntity : class
    {
        protected ResourceBoxContext resourceBoxContext;
        protected DbSet<TEntity> DbSet;

        public RepositoryBase()
        {
            resourceBoxContext = new ResourceBoxContext();
            DbSet = resourceBoxContext.Set<TEntity>();
        }

        public void Add(TEntity obj)
        {
            DbSet.Add(obj);
            resourceBoxContext.SaveChanges();
        }

        public TEntity GetById(long id)
        {
            return DbSet.Find(id);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return DbSet.ToList();
        }

        public void Update(TEntity obj)
        {
            var entry = resourceBoxContext.Entry(obj);
            DbSet.Attach(obj);
            entry.State = EntityState.Modified;
            resourceBoxContext.SaveChanges();
        }

        public void Remove(TEntity obj)
        {
            DbSet.Remove(obj);
            resourceBoxContext.SaveChanges();
        }

        public void Dispose()
        {
            resourceBoxContext.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}
