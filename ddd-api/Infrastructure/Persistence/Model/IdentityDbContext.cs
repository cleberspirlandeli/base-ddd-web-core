using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Persistence.Model
{
    public class DefaultIdentityDbContext : IdentityDbContext
    {
        public DefaultIdentityDbContext(DbContextOptions<DefaultIdentityDbContext> options) 
            : base(options) { }
    }
}
