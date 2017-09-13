using System;
using System.Collections.Generic;
using ResourceBox.Application.Interfaces;
using ResourceBox.Application.ViewModel;

namespace ResourceBox.Application.Services
{
    public class RecursoAppService : AppServiceBase<RecursoViewModel>, IRecursoAppService
    {
        public void Add(RecursoViewModel obj)
        {            
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<RecursoViewModel> GetAll()
        {
            throw new NotImplementedException();
        }

        public RecursoViewModel GetById(long id)
        {
            throw new NotImplementedException();
        }

        public void Remove(RecursoViewModel obj)
        {
            throw new NotImplementedException();
        }

        public void Update(RecursoViewModel obj)
        {
            throw new NotImplementedException();
        }
    }
}
