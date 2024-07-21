// TarefaContextFactory.cs
using BlazorAppApi.Context;
using Microsoft.EntityFrameworkCore;

public class TarefaContextFactory : IDbContextFactory<TarefaContext>
{
    private readonly DbContextOptions<TarefaContext> _options;

    public TarefaContextFactory(DbContextOptions<TarefaContext> options)
    {
        _options = options;
    }

    public TarefaContext CreateDbContext()
    {
        return new TarefaContext(_options);
    }
}
