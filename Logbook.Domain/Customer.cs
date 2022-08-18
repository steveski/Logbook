namespace Logbook.Domain;

public class Customer
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }


    // EntityFramework specific
    public ICollection<LogEntry> LogEntries { get; set; }

}
