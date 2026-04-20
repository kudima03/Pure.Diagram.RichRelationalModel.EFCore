using Microsoft.EntityFrameworkCore.Metadata;
using Pure.Diagram.RichRelationalModel.EFCore.Models;

namespace Pure.Diagram.RichRelationalModel.EFCore.Tests;

public sealed class DiagramDbContextTests(DiagramDbContextFixture fixture)
    : IClassFixture<DiagramDbContextFixture>
{
    [Fact]
    public void DiagramsDbSetIsNotNull()
    {
        Assert.NotNull(fixture.Context.Diagrams);
    }

    [Fact]
    public void TypesDbSetIsNotNull()
    {
        Assert.NotNull(fixture.Context.Types);
    }

    [Fact]
    public void SeriesDbSetIsNotNull()
    {
        Assert.NotNull(fixture.Context.Series);
    }

    [Fact]
    public void OnModelCreatingRegistersDiagramEntity()
    {
        IEntityType? entityType = fixture.Context.Model.FindEntityType(
            typeof(DiagramEFCoreModel)
        );
        Assert.NotNull(entityType);
    }

    [Fact]
    public void OnModelCreatingRegistersDiagramTypeEntity()
    {
        IEntityType? entityType = fixture.Context.Model.FindEntityType(
            typeof(DiagramTypeEFCoreModel)
        );
        Assert.NotNull(entityType);
    }

    [Fact]
    public void OnModelCreatingRegistersSeriesEntity()
    {
        IEntityType? entityType = fixture.Context.Model.FindEntityType(
            typeof(DiagramSeriesEFCoreModel)
        );
        Assert.NotNull(entityType);
    }

    [Fact]
    public void DiagramEntityHasPrimaryKey()
    {
        IEntityType? entityType = fixture.Context.Model.FindEntityType(
            typeof(DiagramEFCoreModel)
        );
        Assert.NotNull(entityType?.FindPrimaryKey());
    }

    [Fact]
    public void DiagramTypeEntityHasPrimaryKey()
    {
        IEntityType? entityType = fixture.Context.Model.FindEntityType(
            typeof(DiagramTypeEFCoreModel)
        );
        Assert.NotNull(entityType?.FindPrimaryKey());
    }

    [Fact]
    public void SeriesEntityHasPrimaryKey()
    {
        IEntityType? entityType = fixture.Context.Model.FindEntityType(
            typeof(DiagramSeriesEFCoreModel)
        );
        Assert.NotNull(entityType?.FindPrimaryKey());
    }

    [Fact]
    public void DiagramEntityHasForeignKeyToDiagramType()
    {
        IEntityType? entityType = fixture.Context.Model.FindEntityType(
            typeof(DiagramEFCoreModel)
        );
        Assert.Contains(
            entityType!.GetForeignKeys(),
            fk => fk.PrincipalEntityType.ClrType == typeof(DiagramTypeEFCoreModel)
        );
    }

    [Fact]
    public void SeriesEntityHasForeignKeyToDiagram()
    {
        IEntityType? entityType = fixture.Context.Model.FindEntityType(
            typeof(DiagramSeriesEFCoreModel)
        );
        Assert.Contains(
            entityType!.GetForeignKeys(),
            fk => fk.PrincipalEntityType.ClrType == typeof(DiagramEFCoreModel)
        );
    }
}
