using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Service.ApplicationService;

namespace Service.DependencyInjection.ApplicationServiceBindings
{
    public class ApplicationServiceInjection
    {
        public static void RegisterBindings(IServiceCollection services, IConfiguration configuration)
        {

            services.AddScoped<ClienteApplicationService>();

        }
    }
}
