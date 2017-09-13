using Ninject.Modules;
using ResourceBox.Application.Interfaces;
using ResourceBox.Application.Services;
using ResourceBox.Domain.Interfaces.Repository;
using ResourceBox.Domain.Services;
using ResourceBox.Infra.Data.Repositories;

namespace ResourceBox.IoC
{
    public class NinjectModulo : NinjectModule
    {
        public override void Load()
        {
            //App
            Bind<IRecursoAppService>().To<RecursoAppService>();

            //Domain
            Bind(typeof(IRepositoryBase<>)).To(typeof(RepositoryBase<>));
            Bind<IRecursoRepository>().To<RecursoRepository>();
            Bind(typeof(IServiceBase<>)).To(typeof(ServiceBase<>));
            Bind<IRecursoService>().To<RecursoService>();          
        }
    }
}
