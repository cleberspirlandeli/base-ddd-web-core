using Domain.Modules.Cadastro;
using Infrastructure.Persistence.Model;
using Infrastructure.Repository.Modules.Cadastro;
using Infrastructure.UnitOfWork.Base;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace Infrastructure.UnitOfWork.Modules.Cadastro
{
    public class ClienteUnitOfWork : GenericUnitOfWork
    {
        public ClienteRepository ClienteRepository => _serviceProvider.GetService<ClienteRepository>();

        public ClienteUnitOfWork(DefaultDataBaseContext context, IServiceProvider serviceProvider) : base(context, serviceProvider) {}

        public IQueryable<Cliente> GetById(int id) => _context.Cliente.Where(x => x.Id == id);         
    }
}
