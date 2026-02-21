using Aiursoft.AnduinOSHome.Entities;
using Microsoft.EntityFrameworkCore;

namespace Aiursoft.AnduinOSHome.InMemory;

public class InMemoryContext(DbContextOptions<InMemoryContext> options) : AnduinOSHomeDbContext(options)
{
    public override Task MigrateAsync(CancellationToken cancellationToken)
    {
        return Database.EnsureCreatedAsync(cancellationToken);
    }

    public override Task<bool> CanConnectAsync()
    {
        return Task.FromResult(true);
    }
}
