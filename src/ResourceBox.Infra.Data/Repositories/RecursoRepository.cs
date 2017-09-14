using ResourceBox.Domain.Entities;
using ResourceBox.Domain.Interfaces.Repository;

namespace ResourceBox.Infra.Data.Repositories
{
    public class RecursoRepository : RepositoryBase<Recurso>, IRecursoRepository
    {
        public void Remove(long id)
        {
            DbSet.Remove(DbSet.Find(id));
            resourceBoxContext.SaveChanges();
        }
    }
}
