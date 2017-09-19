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
            CreateMap<Entrada, EntradaViewModel>();
            CreateMap<Responsavel, ResponsavelViewModel>();
        }
    }
}
