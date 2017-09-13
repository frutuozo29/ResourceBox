using ResourceBox.Domain.Services;

namespace ResourceBox.Application.Services
{
    public class AppServiceBase<TEntity> where TEntity : class
    {
        protected readonly IServiceBase<TEntity> serviceBase;
    }
}
