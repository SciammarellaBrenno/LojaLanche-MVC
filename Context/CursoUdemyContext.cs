using CursoUdemy.Extensions;
using CursoUdemy.Models;
using Microsoft.EntityFrameworkCore;

namespace CursoUdemy.Context;

public class CursoUdemyContext : DbContext
{
    public CursoUdemyContext(DbContextOptions<CursoUdemyContext> options)   : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Seed();

        modelBuilder.Entity<Categoria>().HasMany(x => x.Lanches).WithOne(x => x.Categoria).OnDelete(DeleteBehavior.Restrict);
    }

    public DbSet<Categoria> Categorias { get; set; }
    public DbSet<Lanche> Lanches { get; set; }
}
