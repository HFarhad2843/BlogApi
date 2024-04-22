using BlogApp.Domain.Entities;
using BlogApp.Persistence.Configuration;
using Microsoft.EntityFrameworkCore;

namespace BlogApp.Persistence.Contexts;

public class AppDbContext: DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
    DbSet <Blog> Blogs { get; set; }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(BlogConfiguration).Assembly);
        base.OnModelCreating(modelBuilder);
    }
}
