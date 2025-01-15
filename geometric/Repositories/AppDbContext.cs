using geometric.Models;
using geometric.Repositories.Config;
using Microsoft.EntityFrameworkCore;

namespace geometric.Repositories
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Geometric> Geometrics{ get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new GeometricConfig());
        }
    }
}
