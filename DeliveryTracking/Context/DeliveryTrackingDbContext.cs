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
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(DeliveryTrackingDbContext).Assembly);
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Delivery>()
                .HasOne(e => e.Employee)
                .WithMany(d => d.Deliveries)
                .HasForeignKey(f => f.EmployeeId);

            modelBuilder.Entity<Delivery>()
                .HasOne(e => e.Epi)
                .WithMany(d => d.Deliveries)
                .HasForeignKey(id => id.EpiId);
        }
    }
}
