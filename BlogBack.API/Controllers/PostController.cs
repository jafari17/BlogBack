using BlogBack.Application.Contracts;
using BlogBack.Application.Services_.Post_.Commands.Create;
using BlogBack.Application.Services_.Post_.Commands.Delete;
using BlogBack.Application.Services_.Post_.Commands.Update;
using BlogBack.Application.Services_.Post_.Queries.GetListPostByUserId;
using BlogBack.Application.Services_.Post_.Queries.GetPost;
using BlogBack.Application.Services_.Post_.Queries.GetPostById;
using BlogBack.Application.ViewModels;
using BlogBack.Domain;
using BlogBack.Infrastructure.Repositories;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting;
using System.Collections.Generic;

namespace BlogBack.API.Controllers
{
    
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class PostController : Controller
    {
        private readonly IMediator _mediator;
        private readonly IPostRepository _postRepository;
        private readonly IWebHostEnvironment _environment;


        public PostController(IMediator mediator, IPostRepository postRepository, IWebHostEnvironment environment)
        {
            _mediator = mediator;
            _postRepository = postRepository;
            _environment = environment;
        }
        [Authorize]
        [HttpPost]
        public async Task<IActionResult> AddPost(PostDto postdto)
        {

            var command = new CreatePostCommand()
            {
                PostDto = postdto,
            };
            var response = await _mediator.Send(command);
            return Ok();
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
        [Authorize]
        [HttpGet]
        public async Task<IActionResult> GetListPostByUserIdAsync(string id)
        {
            var query = new GetListPostByUserIdQuery() { UserId = id };
            var response = await _mediator.Send(query);
            return Ok(response);
        }
        [Authorize]
        [HttpDelete]
        public async Task<IActionResult> DeletePost(int id)
        {
            var command = new DeletePostCommand() { PostId = id };
            var response = await _mediator.Send(command);

            if (response != null)
            {
                var path = this._environment.WebRootPath + "\\Uploads\\Product\\" + response;
                if ( Directory.Exists(path))
                {
                    System.IO.Directory.Delete(path, true);
                }

            }

            return Ok();
        }
        [Authorize]
        [HttpPut]
        public async Task<IActionResult> UpdatePost(PostDto postdto)
        {
            var command = new UpdatePostCommand()
            {
                PostDto = postdto,
            };
            var response = await _mediator.Send(command);
            return Ok();
        }

    }
}
