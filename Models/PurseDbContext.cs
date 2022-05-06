using Microsoft.EntityFrameworkCore;

namespace _3312FinalSpring22.Models
{

public class PurseDbContext : DbContext
    {
        public PurseDbContext (DbContextOptions<PurseDbContext> options)
            : base(options)
            {
            }

            public DbSet<Purse> Purse {get; set;}
    }
}