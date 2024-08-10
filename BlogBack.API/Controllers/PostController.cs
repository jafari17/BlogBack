using BlogBack.Application.Services_.Post_.Commands.Create;
using BlogBack.Application.Services_.Post_.Queries.GetPost;
using BlogBack.Application.ViewModels;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace BlogBack.API.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class PostController : Controller
    {
        private readonly IMediator _mediator;

        public PostController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> AddPost( string title, int category, string Description, bool Active)
        {
            var command = new CreatePostCommand()
            {
                 Title = title,
                 CategoryId = category,
                 Description = Description,
                 Active = Active
            };
            var response = await _mediator.Send(command); 
            return Ok(response);
        }

        [HttpGet]
        public async Task<IActionResult> GetPost()
        {

            var query = new GetPostQuery(){};
            var response = await _mediator.Send(query);
            return Ok(response);
        }
    }
}
