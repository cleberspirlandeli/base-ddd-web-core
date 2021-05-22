using Domain.Modules.Cadastro;
using Infrastructure.Persistence.Model;
using Infrastructure.Repository.Base;
using System.Linq;

namespace Infrastructure.Repository.Modules.Cadastro
{
    public class ClienteRepository : GenericRepository<Cliente, DefaultDataBaseContext>
    {
        public ClienteRepository(DefaultDataBaseContext context) : base(context) { }

        public IQueryable<Cliente> GetById(int id) => _context.Cliente.Where(x => x.Id == id);

    }
}
