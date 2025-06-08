using CleanArchitecturePoc.Infrastructure.Entities;
using Microsoft.EntityFrameworkCore;

namespace CleanArchitecturePoc.Infrastructure;

public class MyDbContext(DbContextOptions<MyDbContext> options) : DbContext(options)
{
    public DbSet<MovieEntity> Movies => Set<MovieEntity>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // modelBuilder.ApplyConfigurationsFromAssembly(typeof(MyDbContext).Assembly);
    }
}