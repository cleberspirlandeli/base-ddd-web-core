using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Service.DependencyInjection.ApplicationServiceBindings;
using Service.DependencyInjection.RepositoryBindings;
using Service.DependencyInjection.UnitOfWorkBindings;

namespace Service
{
    public class ConfigureBindingsDependencyInjection
    {
        public static void RegisterBindings(IServiceCollection services, IConfiguration configuration)
        {
            ConfigureBindingsDatabaseContext.RegisterBindings(services, configuration);

            #region ApplicationService
            ApplicationServiceInjection.RegisterBindings(services, configuration);
            #endregion



            #region Repository
            RepositoryInjection.RegisterBindings(services, configuration);
            #endregion



            #region UnitOfWork
            UnitOfWorkInjection.RegisterBindings(services, configuration);
            #endregion
        }
    }
}
