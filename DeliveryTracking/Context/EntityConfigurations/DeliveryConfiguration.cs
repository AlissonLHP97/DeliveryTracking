using DeliveryTracking.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DeliveryTracking.Context.EntityConfigurations
{
    public class DeliveryConfiguration : IEntityTypeConfiguration<Delivery>
    {
        public void Configure(EntityTypeBuilder<Delivery> builder)
        {
            builder.ToTable("Delivery");

            builder.HasKey(x => x.Id);
            
            builder.Property(e => e.Quantity)
                .IsRequired();

            builder.Property(e => e.DateOfDelivery)
                .HasColumnType("date")
                .IsRequired();

            builder.HasOne(e => e.Employee)
                .WithMany(d => d.Deliveries)
                .HasForeignKey(f => f.EmployeeId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(e => e.Epi)
                .WithMany(d => d.Deliveries)
                .HasForeignKey(id => id.EpiId)
                .OnDelete(DeleteBehavior.Restrict);


        }
    }
}
