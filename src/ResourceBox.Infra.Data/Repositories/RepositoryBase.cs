using ResourceBox.Domain.Interfaces.Repository;
using ResourceBox.Infra.Data.Context;
using System.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity.Migrations;

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
            DbSet.AddOrUpdate(obj);
            resourceBoxContext.SaveChanges();
        }

        public void Remove(long id)
        {
            var obj = DbSet.Find(id);
            if (obj != null)
            {
                DbSet.Remove(obj);
                resourceBoxContext.SaveChanges();
            }
            
        }

        public void Dispose()
        {
            resourceBoxContext.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}
