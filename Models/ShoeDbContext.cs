using Microsoft.EntityFrameworkCore;

namespace _3312FinalSpring22.Models
{

public class ShoeDbContext : DbContext
    {
        public ShoeDbContext (DbContextOptions<ShoeDbContext> options)
            : base(options)
            {
            }

            public DbSet<Shoe> Shoe {get; set;}
    }
}