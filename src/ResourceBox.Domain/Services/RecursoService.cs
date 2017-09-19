using ResourceBox.Domain.Entities;
using ResourceBox.Domain.Interfaces.Repository;

namespace ResourceBox.Domain.Services
{
    public class RecursoService : ServiceBase<Recurso>, IRecursoService
    {
        private readonly IRecursoRepository recursoRepository;

        public RecursoService(IRecursoRepository recursoRepository) 
            : base(recursoRepository)
        {
            this.recursoRepository = recursoRepository;
        }
    }
}
