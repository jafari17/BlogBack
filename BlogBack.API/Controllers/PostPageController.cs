using BlogBack.Application.Contracts;
using BlogBack.Application.Services_.Post_.Queries.GetPost;
using BlogBack.Application.Services_.Post_.Queries.GetPostById;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BlogBack.API.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class PostPageController : Controller
    {

        private readonly IMediator _mediator;
        private readonly IPostRepository _postRepository;
        private readonly IWebHostEnvironment _environment;


        public PostPageController(IMediator mediator, IPostRepository postRepository, IWebHostEnvironment environment)
        {
            _mediator = mediator;
            _postRepository = postRepository;
            _environment = environment;
        }


        [HttpGet]
        public async Task<IActionResult> GetPost()
        {
            var query = new GetPostQuery() { };
            var response = await _mediator.Send(query);
            return Ok(response);
        }


        [HttpGet]
        public async Task<IActionResult> GetPostById(int id)
        {
            var query = new GetPostByIdQuery() { PostId = id };
            var response = await _mediator.Send(query);
            return Ok(response);
        }



    }
}
