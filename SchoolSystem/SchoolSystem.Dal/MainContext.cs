using Microsoft.EntityFrameworkCore;

namespace SchoolSystem.Dal;

public class MainContext : DbContext
{
    public MainContext(DbContextOptions options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
    }

}
