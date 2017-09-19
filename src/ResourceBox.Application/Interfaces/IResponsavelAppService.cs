using ResourceBox.Application.ViewModel;
using System;
using System.Collections.Generic;

namespace ResourceBox.Application.Interfaces
{
    public interface IResponsavelAppService : IDisposable
    {
        void Add(ResponsavelViewModel obj);
        ResponsavelViewModel GetById(long id);
        IEnumerable<ResponsavelViewModel> GetAll();
        void Update(ResponsavelViewModel obj);
        void Remove(long id);
    }
}
