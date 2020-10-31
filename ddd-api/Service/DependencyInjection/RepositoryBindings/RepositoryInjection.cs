using Infrastructure.Repository.FuncionalidadeCliente;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Service.DependencyInjection.RepositoryBindings
{
    public class RepositoryInjection
    {
        public static void RegisterBindings(IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<ClienteRepository>();
        }
    }
}
