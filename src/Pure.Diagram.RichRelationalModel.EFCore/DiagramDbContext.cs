using Microsoft.EntityFrameworkCore;
using Pure.Diagram.RichRelationalModel.EFCore.Models;
using Pure.Diagram.RichRelationalModel.EFCore.Models.Configurations;

namespace Pure.Diagram.RichRelationalModel.EFCore;

public sealed class DiagramDbContext(DbContextOptions<DiagramDbContext> options)
    : DbContext(options)
{
    public DbSet<DiagramEFCoreModel> Diagrams => Set<DiagramEFCoreModel>();

    public DbSet<DiagramTypeEFCoreModel> Types => Set<DiagramTypeEFCoreModel>();

    public DbSet<DiagramSeriesEFCoreModel> Series => Set<DiagramSeriesEFCoreModel>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        _ = modelBuilder.ApplyConfiguration(new DiagramSeriesConfiguration());
        _ = modelBuilder.ApplyConfiguration(new DiagramTypeConfiguration());
        _ = modelBuilder.ApplyConfiguration(new DiagramConfiguration());
    }
}
