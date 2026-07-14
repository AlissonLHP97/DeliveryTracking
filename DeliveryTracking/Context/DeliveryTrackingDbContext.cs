using DeliveryTracking.Models;
using Microsoft.EntityFrameworkCore;

namespace DeliveryTracking.Context
{
    public class DeliveryTrackingDbContext : DbContext
    {
        public DeliveryTrackingDbContext(DbContextOptions<DeliveryTrackingDbContext> options) : base(options) { }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Epi> Epis { get; set; }
        public DbSet<Delivery> Deliveries { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(DeliveryTrackingDbContext).Assembly);

        }
    }
}
