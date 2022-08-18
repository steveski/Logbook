namespace Logbook.Database;

using Microsoft.EntityFrameworkCore;

public class EntityDbContext : DbContext
{
    private readonly string _dbPath;

    public EntityDbContext(string dbPath)
    {
        _dbPath = dbPath;
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite($"Data Source={_dbPath}");

        base.OnConfiguring(optionsBuilder);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(EntityDbContext).Assembly);



        base.OnModelCreating(modelBuilder);
    }
}
