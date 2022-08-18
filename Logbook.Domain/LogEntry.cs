namespace Logbook.Domain;

public class LogEntry
{
    public int Id { get; set; }
    public JobType JobType { get; set; }
    public string? JobTypeOther { get; set; }

    public EquipmentType EquipmentType { get; set; }

    public DateTime DateComplete { get; set; }

    public Customer Customer { get; set; }

    public ICollection<EquipmentDetails> EquipmentDetails { get; set; }

    // EntityFramework specific
    public int CustomerId { get; set; }


}