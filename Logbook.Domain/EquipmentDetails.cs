namespace Logbook.Domain;

public class EquipmentDetails
{
    public int Id { get; set; }

    public ComponentType ComponentType { get; set; }
    public string? Manufacturer { get; set; }
    public string? Model { get; set; }
    public string? SerialNumber { get; set; }
    public DateOnly? DateOfManufacture { get; set; }

    // EntityFramework specific
    public ICollection<LogEntry> LogEntries { get; set; }

}
