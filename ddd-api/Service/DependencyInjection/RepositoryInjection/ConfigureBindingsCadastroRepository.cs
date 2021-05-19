using Infrastructure.Repository.Modules.Cadastro;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Service.DependencyInjection.RepositoryInjection
{
    public class ConfigureBindingsCadastroRepository
    {
        public static void RegisterBindings(IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<ClienteRepository>();
        }
    }
}
