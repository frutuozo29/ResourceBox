using ResourceBox.Application.Interfaces;
using ResourceBox.Application.Services;
using ResourceBox.Domain.Interfaces.Repository;
using ResourceBox.Domain.Interfaces.Services;
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
            container.Register<IResponsavelAppService, ResponsavelAppService>(Lifestyle.Singleton);
            container.Register<IEntradaAppService, EntradaAppService>(Lifestyle.Singleton);

            //Domain
            container.Register(typeof(IRepositoryBase<>), typeof(RepositoryBase<>));
            container.Register<IRecursoRepository, RecursoRepository>(Lifestyle.Singleton);
            container.Register<IEntradaRepository, EntradaRepository>(Lifestyle.Singleton);
            container.Register<IResponsavelRepository, ResponsavelRepository>(Lifestyle.Singleton);

            container.Register(typeof(IServiceBase<>), typeof(ServiceBase<>));
            container.Register<IRecursoService, RecursoService>(Lifestyle.Singleton);
            container.Register<IEntradaService, EntradaService>(Lifestyle.Singleton);
            container.Register<IResponsavelService, ResponsavelService>(Lifestyle.Singleton);
        }
    }
}
