using Infrastructure.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Service
{
    public class ConfigureBindingsDatabaseContext
    {
        public static void RegisterBindings(IServiceCollection services, IConfiguration configuration)
        {
            services
                .AddEntityFrameworkSqlServer()
                .AddDbContext<DefaultDataBaseContext>(
                        options => options.UseSqlServer(configuration.GetConnectionString("DefaultConnectionString"),
                        providerOptions => providerOptions.EnableRetryOnFailure())
                );
        }
    }
}
