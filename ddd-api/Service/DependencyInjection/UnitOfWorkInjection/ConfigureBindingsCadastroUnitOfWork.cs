using Infrastructure.UnitOfWork.Modules.Cadastro;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Service.DependencyInjection.UnitOfWorkInjection
{
    public class ConfigureBindingsCadastroUnitOfWork
    {
        public static void RegisterBindings(IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<ClienteUnitOfWork>();
        }
    }
}
