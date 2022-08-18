using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Logbook.Database.Configurations;

using Domain;
using Microsoft.EntityFrameworkCore;

public class LogEntryConfiguration : IEntityTypeConfiguration<LogEntry>

{
    public void Configure(EntityTypeBuilder<LogEntry> builder)
    {
        builder.ToTable("LogEntry");
        builder.HasKey(l => l.Id);

        builder.Property(l => l.JobType).HasConversion<string>().HasColumnType("TEXT").IsRequired();
        builder.Property(l => l.JobTypeOther).HasColumnType("TEXT");
        builder.Property(l => l.EquipmentType).HasConversion<string>().HasColumnType("TEXT").IsRequired();
        builder.Property(l => l.DateComplete).HasColumnType("TEXT").IsRequired();

        builder.HasOne<Customer>()
            .WithMany(c => c.LogEntries)
            .HasForeignKey(l => l.CustomerId);
    }
}
