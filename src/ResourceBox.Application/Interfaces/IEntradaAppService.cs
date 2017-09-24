using ResourceBox.Application.ViewModel;
using System;
using System.Collections.Generic;

namespace ResourceBox.Application.Interfaces
{
    public interface IEntradaAppService : IDisposable
    {
        void Add(EntradaViewModel obj);
        EntradaViewModel GetById(long id);
        IEnumerable<EntradaViewModel> GetAll();
        void Update(EntradaViewModel obj);
        void Remove(long id);
    }
}
