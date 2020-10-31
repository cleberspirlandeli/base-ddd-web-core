using System;
using Infrastructure.Model;
using Infrastructure.UnitOfWork.Base;
using Microsoft.Extensions.DependencyInjection;
using Infrastructure.Repository.FuncionalidadeCliente;

namespace Infrastructure.UnitOfWork.FuncionalidadeCliente
{
    public class ClienteUnitOfWork : GenericUnitOfWork
    {
        public ClienteRepository ClienteRepository => _serviceProvider.GetService<ClienteRepository>();

        public ClienteUnitOfWork(DefaultDataBaseContext context, IServiceProvider serviceProvider) : base(context, serviceProvider)
        {
        }
    }
}
