
using Infrastructure.Persistence.Model;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Service
{
    public class ConfigureBindingsDatabaseContext
    {
        public static void RegisterBindings(IServiceCollection services, IConfiguration configuration)
        {
            // Identity
            services.AddDbContext<DefaultIdentityDbContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

            services.AddDefaultIdentity<IdentityUser>()
                .AddRoles<IdentityRole>()
                .AddEntityFrameworkStores<DefaultIdentityDbContext>()
                .AddErrorDescriber<IdentityMesagePortuguese>()
                .AddDefaultTokenProviders();

            // DataBase
            services
              .AddDbContextPool<DefaultDataBaseContext>(options =>
              {
                  options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"),
                          providerOptions => providerOptions.EnableRetryOnFailure());
              });
        }
    }
}
