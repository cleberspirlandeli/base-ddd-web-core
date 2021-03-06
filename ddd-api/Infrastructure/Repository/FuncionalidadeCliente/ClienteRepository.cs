﻿using Domain.Models.FuncionalidadeCliente;
using Infrastructure.Model;
using Infrastructure.Repository.Base;
using System.Linq;

namespace Infrastructure.Repository.FuncionalidadeCliente
{
    public class ClienteRepository : GenericRepository<Cliente, DefaultDataBaseContext>
    {
        public ClienteRepository(DefaultDataBaseContext context) : base(context)
        {
        }

        public IQueryable<Cliente> GetById(int id)
        {
            return _context.Cliente.Where(x => x.Id == id);
        }
    }
}
