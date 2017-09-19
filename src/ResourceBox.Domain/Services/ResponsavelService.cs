using ResourceBox.Domain.Entities;
using ResourceBox.Domain.Interfaces.Repository;
using ResourceBox.Domain.Interfaces.Services;

namespace ResourceBox.Domain.Services
{
    public class ResponsavelService : ServiceBase<Responsavel>, IResponsavelService
    {
        private readonly IResponsavelRepository responsavelRepository;

        public ResponsavelService(IResponsavelRepository responsavelRepository) 
            : base(responsavelRepository)
        {
            this.responsavelRepository = responsavelRepository;
        }
    }
}
