using BlogApp.Application.Repositories;
using BlogApp.Domain.Entities.Common;
using BlogApp.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace BlogApp.Persistence.RepositoryImplementations;

public class GenericRepository<TEntity> 
             : IGenericRepository<TEntity> where TEntity 
             : BaseEntity, new()
{
    private readonly AppDbContext context;

    public GenericRepository(AppDbContext context)
    {
        this.context = context;
    }
    public DbSet<TEntity> Table => context.Set<TEntity>();
    

    public async Task CommitAsync()
    {
        await context.SaveChangesAsync();
    }

    public void Delete(TEntity entity)
    {
        Table.Remove(entity);
    }

    public async Task<TEntity> GetByIdAsync(int id)
     => await Table.FindAsync(id);
   
    

    public async Task<ICollection<TEntity>> GetAllAsync(Expression<Func<TEntity, bool>>? expression = null, params string[]? includes)
    => await Table.ToListAsync();


    public async Task InsertAsync(TEntity entity)
    => await Table.AddAsync(entity);

    async Task<TEntity> IGenericRepository<TEntity>.GetSingleAsync(Expression<Func<TEntity, bool>>? expression, params string[]? includes)
    => await Table.FirstOrDefaultAsync(expression);
}
