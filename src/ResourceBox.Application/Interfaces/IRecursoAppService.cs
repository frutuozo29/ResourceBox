using ResourceBox.Application.ViewModel;
using System;
using System.Collections.Generic;

namespace ResourceBox.Application.Interfaces
{
    public interface IRecursoAppService : IDisposable
    {
        void Add(RecursoViewModel obj);
        RecursoViewModel GetById(long id);
        IEnumerable<RecursoViewModel> GetAll();
        void Update(RecursoViewModel obj);
        void Remove(long id);        
    }
}
