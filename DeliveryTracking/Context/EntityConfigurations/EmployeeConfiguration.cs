using DeliveryTracking.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DeliveryTracking.Context.EntityConfigurations
{
    public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.ToTable("Employee");

            builder.Property(e => e.Name)
                .HasMaxLength(100)
                .IsRequired();

            builder.Property(e => e.Cpf)
                .HasMaxLength(11)
                .IsRequired();

            builder.Property(e => e.Cargo)
                .HasMaxLength(50)
                .IsRequired();

            builder.Property(e => e.Sector)
                .HasMaxLength(50)
                .IsRequired();

            builder.Property(e => e.DateOfAdmission)
                .HasColumnType("date")
                .IsRequired();

            builder.HasIndex(e => e.Cpf)
                .IsUnique();

        }
    }
}
