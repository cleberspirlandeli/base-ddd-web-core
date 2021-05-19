using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Persistence.Model
{
    public class GenericContext : DbContext
    {
        public GenericContext(DbContextOptions options) : base(options)
        {
            Database.SetCommandTimeout(36000);
            ChangeTracker.AutoDetectChangesEnabled = false;
        }

    }
}
