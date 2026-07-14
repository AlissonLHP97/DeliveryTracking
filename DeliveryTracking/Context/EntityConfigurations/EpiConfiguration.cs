using DeliveryTracking.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DeliveryTracking.Context.EntityConfigurations
{
    public class EpiConfiguration : IEntityTypeConfiguration<Epi>
    {
        public void Configure(EntityTypeBuilder<Epi> builder)
        {
            builder.ToTable("Epi");

            builder.Property(e => e.Name)
                .HasMaxLength(100)
                .IsRequired();

            builder.Property(e => e.Ca)
                .HasMaxLength(20)
                .IsRequired();

            builder.Property(e => e.Manufacturer)
                .HasMaxLength (50)
                .IsRequired();

            builder.Property(e => e.QuantityInStock)
                .IsRequired();

            builder.HasIndex(e => e.Ca)
                .IsUnique();
        }
    }
}
