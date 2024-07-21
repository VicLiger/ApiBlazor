using BlazorAppApi.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazorAppApi.Context
{
    public class TarefaContext : DbContext
    {
        public TarefaContext(DbContextOptions<TarefaContext> options) : base(options){ }

        public DbSet<Tarefa> Tarefas { get; set; } = null!;
    }
}
