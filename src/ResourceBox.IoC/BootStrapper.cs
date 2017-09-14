using ResourceBox.Application.Interfaces;
using ResourceBox.Application.Services;
using ResourceBox.Domain.Interfaces.Repository;
using ResourceBox.Domain.Services;
using ResourceBox.Infra.Data.Repositories;
using SimpleInjector;

namespace ResourceBox.IoC
{
    public class BootStrapper
    {
        public static void RegisterServices(Container container)
        {
            //Application
            container.Register<IRecursoAppService, RecursoAppService>(Lifestyle.Singleton);

            //Domain
            container.Register(typeof(IRepositoryBase<>), typeof(RepositoryBase<>));
            container.Register<IRecursoRepository, RecursoRepository>(Lifestyle.Singleton);

            container.Register(typeof(IServiceBase<>), typeof(ServiceBase<>));
            container.Register<IRecursoService, RecursoService>(Lifestyle.Singleton);
        }
    }
}
