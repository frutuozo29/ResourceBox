using ResourceBox.Domain.Entities;
using ResourceBox.Domain.Interfaces.Repository;
using ResourceBox.Domain.Interfaces.Services;

namespace ResourceBox.Domain.Services
{
    public class EntradaService : ServiceBase<Entrada>, IEntradaService
    {
        private readonly IEntradaRepository entradaRepository;

        public EntradaService(IEntradaRepository entradaRepository) 
            : base(entradaRepository)
        {
            this.entradaRepository = entradaRepository;
        }
    }
}
