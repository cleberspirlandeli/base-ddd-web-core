using Infrastructure.Model;
using Infrastructure.Repository.Modules.Cadastro;
using Infrastructure.UnitOfWork.Base;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace Infrastructure.UnitOfWork.Modules.Cadastro
{
    public class ClienteUnitOfWork : GenericUnitOfWork
    {
        public ClienteRepository ClienteRepository => _serviceProvider.GetService<ClienteRepository>();

        public ClienteUnitOfWork(DefaultDataBaseContext context, IServiceProvider serviceProvider) : base(context, serviceProvider)
        {
        }
    }
}
