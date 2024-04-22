using BlogApp.Application.Repositories;
using BlogApp.Persistence.RepositoryImplementations;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlogApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlogsController : ControllerBase
    {
        private readonly IBlogRepository blogRepository;

        public BlogsController(IBlogRepository blogRepository)
        {
            this.blogRepository = blogRepository;
        }
        [HttpGet("")]
        public async Task <IActionResult> Get()
        {
            var datas = blogRepository.GetAllAsync();
            return Ok();
        }
    }
}
