using Domain.Modules.Cadastro;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Persistence.Model
{
    public partial class DefaultDataBaseContext : GenericContext
    {
        public DbSet<Cliente> Cliente;
    }
}
