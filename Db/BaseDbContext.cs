using BaseApp.API.Models;
using Microsoft.EntityFrameworkCore;

namespace BaseApp.API.Db
{
    public class BaseDbContext : DbContext
    {
        public BaseDbContext(DbContextOptions<BaseDbContext> options) : base(options)
        {
        }

        public DbSet<Test> Tests { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Test>().HasData(
                new Test { Id = 1, Name = "Rzv" },
                new Test { Id = 2, Name = "Izu" }
            );
        }
    }
}
