using BlogApp.Application.Repositories;
using BlogApp.Persistence.Contexts;
using BlogApp.Persistence.RepositoryImplementations;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace BlogApp.Persistence;

public static class PersistenceRegistration
{
    public static void AddPersistenceServices (this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<AppDbContext>(opt =>
        {
            opt.UseSqlServer(configuration.GetConnectionString("default"));
        });
        services.AddScoped<IBlogRepository, BlogRepository>();
    }
}
