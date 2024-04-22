using BlogApp.Application.Repositories;
using BlogApp.Domain.Entities;
using BlogApp.Persistence.Contexts;

namespace BlogApp.Persistence.RepositoryImplementations;

public class BlogRepository : GenericRepository<Blog>, IBlogRepository
{
    public BlogRepository(AppDbContext context) : base(context)
    {
    }

    public Task GetAllAsync()
    {
        throw new NotImplementedException();
    }
}
