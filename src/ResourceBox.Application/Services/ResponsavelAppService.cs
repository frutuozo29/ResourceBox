using System;
using System.Collections.Generic;
using ResourceBox.Application.Interfaces;
using ResourceBox.Application.ViewModel;
using ResourceBox.Domain.Interfaces.Services;
using AutoMapper;
using ResourceBox.Domain.Entities;

namespace ResourceBox.Application.Services
{
    public class ResponsavelAppService : AppServiceBase<ResponsavelViewModel>, IResponsavelAppService
    {
        private readonly IResponsavelService responsavelService;

        public ResponsavelAppService(IResponsavelService responsavelService)
        {
            this.responsavelService = responsavelService;
        }

        private ResponsavelViewModel GetMapperRecursoToRecursoViewModel(Responsavel recurso)
        {
            return Mapper.Instance.Map<Responsavel, ResponsavelViewModel>(recurso);
        }

        private Responsavel GetMapperRecursoViewModelToRecurso(ResponsavelViewModel recursoviewmodel)
        {
            return Mapper.Instance.Map<ResponsavelViewModel, Responsavel>(recursoviewmodel);
        }

        public void Add(ResponsavelViewModel obj)
        {
            var responsavel = GetMapperRecursoViewModelToRecurso(obj);
            responsavelService.Add(responsavel);
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        public IEnumerable<ResponsavelViewModel> GetAll()
        {
            return Mapper.Instance.Map<IEnumerable<Responsavel>, IEnumerable<ResponsavelViewModel>>(responsavelService.GetAll());
        }

        public ResponsavelViewModel GetById(long id)
        {
            return GetMapperRecursoToRecursoViewModel(responsavelService.GetById(id));
        }

        public void Remove(long id)
        {
            responsavelService.Remove(id);
        }

        public void Update(ResponsavelViewModel obj)
        {
            var responsavel = GetMapperRecursoViewModelToRecurso(obj);
            responsavel.Id = obj.Id;
            responsavelService.Update(responsavel);
        }
    }
}
