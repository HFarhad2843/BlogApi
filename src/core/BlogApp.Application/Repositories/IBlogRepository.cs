using BlogApp.Domain.Entities;

namespace BlogApp.Application.Repositories;

public interface IBlogRepository : IGenericRepository<Blog>
{
    Task GetAllAsync();
}
