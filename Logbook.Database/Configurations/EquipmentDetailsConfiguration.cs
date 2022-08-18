using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Logbook.Database.Configurations;

using Domain;
using Microsoft.EntityFrameworkCore;

public class EquipmentDetailsConfiguration : IEntityTypeConfiguration<EquipmentDetails>

{
    public void Configure(EntityTypeBuilder<EquipmentDetails> builder)
    {
        builder.ToTable("EquipmentDetails");
        builder.HasKey(e => e.Id);

        builder.Property(e => e.ComponentType).HasConversion<string>().HasColumnType("TEXT").IsRequired();
        builder.Property(e => e.Manufacturer).HasColumnType("TEXT");
        builder.Property(e => e.Model).HasColumnType("TEXT");
        builder.Property(e => e.SerialNumber).HasColumnType("TEXT");
        builder.Property(e => e.DateOfManufacture).HasColumnType("TEXT");


    }
}
