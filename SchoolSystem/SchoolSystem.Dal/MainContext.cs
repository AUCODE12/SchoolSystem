using Microsoft.EntityFrameworkCore;

namespace SchoolSystem.Dal;

public class MainContext : DbContext
{
    public MainContext(DbContextOptions options) : base(options)
    {
    }
}
