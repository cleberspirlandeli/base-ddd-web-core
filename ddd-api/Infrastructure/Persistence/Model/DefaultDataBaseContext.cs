using Domain.Modules.Cadastro;
using Infrastructure.Persistence.Model;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Persistence.Model
{
    public partial class DefaultDataBaseContext : GenericContext
    {

        //protected override void OnConfiguring(DbContextOptions options)
        //{
        //    base.OnConfiguring(options);
        //}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(GetType().Assembly);
        }

        public DefaultDataBaseContext(DbContextOptions options) : base(options)
        {
        }
    }
}
