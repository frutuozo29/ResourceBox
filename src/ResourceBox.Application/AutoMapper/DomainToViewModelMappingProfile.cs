using AutoMapper;
using ResourceBox.Application.ViewModel;
using ResourceBox.Domain.Entities;

namespace ResourceBox.Application.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {
            CreateMap<Recurso, RecursoViewModel>();
            CreateMap<Responsavel, ResponsavelViewModel>();
            CreateMap<Entrada, EntradaViewModel>()
                .ForMember(e => e.ResponsavelNome, opt => opt.MapFrom(src => src.Responsavel.Nome));
            CreateMap<RecursoEntrada, RecursoEntradaViewModel>()
                .ForMember(r => r.RecursoDescricao, opt => opt.MapFrom(src => src.Recurso.Descricao));

        }
    }
}
