using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Service.DependencyInjection.ApplicationServiceInjection;
using Service.DependencyInjection.RepositoryInjection;
using Service.DependencyInjection.UnitOfWorkInjection;
using Service.Interfaces;
using Service.Notificacoes;

namespace Service
{
    public class ConfigureBindingsDependencyInjection
    {
        public static void RegisterBindings(IServiceCollection services, IConfiguration configuration)
        {
            ConfigureBindingsDatabaseContext.RegisterBindings(services, configuration);

            #region Others
            services.AddScoped<INotificador, Notificador>();
            #endregion



            #region ApplicationService
            ConfigureBindingsCadastroApplicationService.RegisterBindings(services, configuration);
            //ConfigureBindingsEstoqueApplicationService.RegisterBindings(services, configuration);
            #endregion



            #region Repository
            ConfigureBindingsCadastroRepository.RegisterBindings(services, configuration);
            //ConfigureBindingsEstoqueRepository.RegisterBindings(services, configuration);
            #endregion



            #region UnitOfWork
            ConfigureBindingsCadastroUnitOfWork.RegisterBindings(services, configuration);
            //ConfigureBindingsEstoqueUnitOfWork.RegisterBindings(services, configuration);
            #endregion



            #region ServiceBus
            #endregion
        }
    }
}
