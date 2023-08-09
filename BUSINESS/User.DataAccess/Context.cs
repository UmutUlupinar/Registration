using Microsoft.EntityFrameworkCore;
using User.DataAccess.EntityConfiguration;

namespace User.DataAccess;

public class Context :DbContext
{
    public Context(DbContextOptions<Context> options):base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new UserEntityConfiguration());
        modelBuilder.ApplyConfiguration(new ProfileEntityConfiguration());
    }
}