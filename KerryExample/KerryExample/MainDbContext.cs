using KerryExample.Entity;
using Microsoft.EntityFrameworkCore;

namespace KerryExample
{
    public class MainDbContext : DbContext
    {

        public MainDbContext(DbContextOptions<MainDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            //base.OnModelCreating(builder);
        }


        public DbSet<User> User { get; set; }
    }
}
