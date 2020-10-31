using Domain.Models.FuncionalidadeCliente;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Model
{
    public class DefaultDataBaseContext : DbContext
    {
        public DefaultDataBaseContext(DbContextOptions<DefaultDataBaseContext> options) : base(options)
        {
        }

        public virtual DbSet<Cliente> Cliente { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(GetType().Assembly);
        }
    }
}
