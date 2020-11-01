using Common;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Service.DependencyInjection.ApplicationServiceBindings;
using Service.DependencyInjection.RepositoryBindings;
using Service.DependencyInjection.UnitOfWorkBindings;
using Service.Interfaces;
using Service.Notificacoes;

namespace Service
{
    public class ConfigureBindingsDependencyInjection
    {
        public static void RegisterBindings(IServiceCollection services, IConfiguration configuration)
        {
            ConfigureBindingsDatabaseContext.RegisterBindings(services, configuration);

            services.AddScoped<INotificador, Notificador>();


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
