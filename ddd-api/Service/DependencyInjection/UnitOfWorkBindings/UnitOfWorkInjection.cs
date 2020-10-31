using Infrastructure.UnitOfWork.FuncionalidadeCliente;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service.DependencyInjection.UnitOfWorkBindings
{
    public class UnitOfWorkInjection
    {
        public static void RegisterBindings(IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<ClienteUnitOfWork>();
        }
    }
}
