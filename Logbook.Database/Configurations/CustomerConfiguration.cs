using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Logbook.Database.Configurations;

using Domain;
using Microsoft.EntityFrameworkCore;

public class CustomerConfiguration : IEntityTypeConfiguration<Customer>

{
    public void Configure(EntityTypeBuilder<Customer> builder)
    {
        builder.ToTable("Customer");
        builder.HasKey(c => c.Id);

        builder.Property(c => c.FirstName).HasMaxLength(50).IsRequired();
        builder.Property(c => c.LastName).HasMaxLength(50).IsRequired();
        
    }
}
