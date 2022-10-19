using CompanyEmployees.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace CompanyEmployees.Infrastructure.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    public DbSet<Company> Companies => Set<Company>();
    public DbSet<Employee> Employees => Set<Employee>();


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }

    public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
    {
        InitEntityBaseProperties();

        return await base.SaveChangesAsync(cancellationToken);
    }

    public override int SaveChanges()
    {
        InitEntityBaseProperties();

        return base.SaveChanges();
    }

    private void InitEntityBaseProperties()
    {
        foreach (var entry in ChangeTracker.Entries())
        {
            if (entry.Entity is EntityBase entity)
            {
                switch (entry.State)
                {
                    case EntityState.Modified:
                    case EntityState.Deleted:
                        entity.LastModifiedDate = DateTime.UtcNow;
                        break;
                    case EntityState.Added:
                        entity.CreatedDate = DateTime.UtcNow;
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
