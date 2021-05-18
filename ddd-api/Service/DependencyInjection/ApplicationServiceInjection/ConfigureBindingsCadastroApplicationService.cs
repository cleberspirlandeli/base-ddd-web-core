using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Service.ApplicationService.Modules.Cadastro;

namespace Service.DependencyInjection.ApplicationServiceInjection
{
    public class ConfigureBindingsCadastroApplicationService
    {
        public static void RegisterBindings(IServiceCollection services, IConfiguration configuration)
        {

            services.AddScoped<ClienteApplicationService>();

        }
    }
}
