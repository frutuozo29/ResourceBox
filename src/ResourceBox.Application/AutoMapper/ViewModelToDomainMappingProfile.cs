using AutoMapper;
using ResourceBox.Application.ViewModel;
using ResourceBox.Domain.Entities;

namespace ResourceBox.Application.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public ViewModelToDomainMappingProfile()
        {
            CreateMap<RecursoViewModel, Recurso>();
            CreateMap<EntradaViewModel, Entrada>();
            CreateMap<ResponsavelViewModel, Responsavel>();
            CreateMap<RecursoEntradaViewModel, RecursoEntrada>();
        }      
    }
}
