using System;
using System.Collections.Generic;
using ResourceBox.Application.Interfaces;
using ResourceBox.Application.ViewModel;
using ResourceBox.Domain.Interfaces.Services;
using ResourceBox.Domain.Entities;
using AutoMapper;

namespace ResourceBox.Application.Services
{
    public class EntradaAppService : AppServiceBase<EntradaViewModel>, IEntradaAppService
    {
        private readonly IEntradaService entradaService;

        public EntradaAppService(IEntradaService entradaService)
        {
            this.entradaService = entradaService;
        }

        private EntradaViewModel GetMapperEntradaToEntradaViewModel(Entrada entrada)
        {
            return Mapper.Instance.Map<Entrada, EntradaViewModel>(entrada);
        }

        private Entrada GetMapperEntradaViewModelToEntrada(EntradaViewModel entradaviewmodel)
        {
            return Mapper.Instance.Map<EntradaViewModel, Entrada>(entradaviewmodel);
        }

        public void Add(EntradaViewModel obj)
        {
            var entrada = GetMapperEntradaViewModelToEntrada(obj);
            entradaService.Add(entrada);
        }

        public IEnumerable<EntradaViewModel> GetAll()
        {
            return Mapper.Instance.Map<IEnumerable<Entrada>, IEnumerable<EntradaViewModel>>(entradaService.GetAll());
        }

        public EntradaViewModel GetById(long id)
        {
            return GetMapperEntradaToEntradaViewModel(entradaService.GetById(id));
        }

        public void Remove(long id)
        {
            entradaService.Remove(id);
        }

        public void Update(EntradaViewModel obj)
        {
            var entrada = GetMapperEntradaViewModelToEntrada(obj);
            entrada.Id = obj.Id;
            entradaService.Update(entrada);
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
