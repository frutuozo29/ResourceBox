using System;
using System.Collections.Generic;
using ResourceBox.Application.Interfaces;
using ResourceBox.Application.ViewModel;
using AutoMapper;
using ResourceBox.Domain.Entities;
using ResourceBox.Domain.Services;

namespace ResourceBox.Application.Services
{
    public class RecursoAppService : AppServiceBase<RecursoViewModel>, IRecursoAppService
    {
        private readonly IRecursoService recursoService;

        public RecursoAppService(IRecursoService recursoService)
        {
            this.recursoService = recursoService;
        }

        private RecursoViewModel GetMapperRecursoToRecursoViewModel(Recurso recurso)
        {
            return Mapper.Instance.Map<Recurso, RecursoViewModel>(recurso);
        }

        private Recurso GetMapperRecursoViewModelToRecurso(RecursoViewModel recursoviewmodel)
        {
            return Mapper.Instance.Map<RecursoViewModel, Recurso>(recursoviewmodel);
        }

        public void Add(RecursoViewModel obj)
        {
            var recurso = GetMapperRecursoViewModelToRecurso(obj);
            recursoService.Add(recurso);
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        public IEnumerable<RecursoViewModel> GetAll()
        {
            return Mapper.Instance.Map<IEnumerable<Recurso>, IEnumerable<RecursoViewModel>>(recursoService.GetAll());
        }

        public RecursoViewModel GetById(long id)
        {
            return GetMapperRecursoToRecursoViewModel(recursoService.GetById(id));
        }

        public void Update(RecursoViewModel obj)
        {
            var recurso = GetMapperRecursoViewModelToRecurso(obj);
            recurso.Id = obj.Id;
            recursoService.Update(recurso);
        }

        public void Remove(long id)
        {
            recursoService.Remove(id);
        }
    }
}
