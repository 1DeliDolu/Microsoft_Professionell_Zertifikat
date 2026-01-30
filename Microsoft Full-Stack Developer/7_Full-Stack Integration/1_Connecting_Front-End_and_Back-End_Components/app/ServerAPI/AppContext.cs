using Microsoft.EntityFrameworkCore;

public class AppContext : DbContext
{
    public AppContext(DbContextOptions<AppContext> options) : base(options)
    {
    }

    // Add your DbSets here
    // public DbSet<YourEntity> YourEntities { get; set; }
}
