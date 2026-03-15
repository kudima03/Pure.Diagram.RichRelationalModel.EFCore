using Microsoft.EntityFrameworkCore;

namespace Pure.Diagram.RichRelationalModel.EFCore.Tests;

public sealed class DiagramDbContextFixture : IDisposable
{
    public DiagramDbContext Context { get; }

    public DiagramDbContextFixture()
    {
        DbContextOptions<DiagramDbContext> options =
            new DbContextOptionsBuilder<DiagramDbContext>()
                .UseInMemoryDatabase(databaseName: nameof(DiagramDbContextTests))
                .Options;

        Context = new DiagramDbContext(options);
    }

    public void Dispose()
    {
        Context.Dispose();
    }
}
