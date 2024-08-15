using BlogBack.Application.Contracts;
 using BlogBack.Application.Services_.Post_.Commands.Create;
using BlogBack.Application.Services_.Post_.Commands.Delete;
using BlogBack.Application.Services_.Post_.Commands.Update;
using BlogBack.Application.Services_.Post_.Queries.GetPost;
using BlogBack.Application.Services_.Post_.Queries.GetPostById;
using BlogBack.Application.ViewModels;
using BlogBack.Domain;
using BlogBack.Infrastructure.Repositories;
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
        private readonly IPostRepository _postRepository;

        public PostController(IMediator mediator, IPostRepository postRepository)
        {
            _mediator = mediator;
            _postRepository = postRepository;
        }

        [HttpPost]
        public async Task<IActionResult> AddPost(PostDto postdto )
        {
            var command = new CreatePostCommand()
            {
                PostDto = postdto,
            };
            var response = await _mediator.Send(command);


            //var post = new Post 
            //{
            //    Title = "سمند",
            //    CategoryId = 1,
            //    Active = false,
            //    Labels = new List<Label >
            //        {
            //            new Label  { LabelName = "لیبل یک" },
            //            new Label  { LabelName = "لیبل دو" },
            //            new Label  { LabelName = "لیبل سه" }
            //        },
            //    Description = "ماشین ایرانی"
            //};

            ////await  _postRepository.AddPostAsync(post); 

            //await _postRepository.SaveChangesAsync(); 


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
          
        [HttpDelete]
        public async Task<IActionResult> DeletePost(int id)
        {
            var command = new DeletePostCommand() { PostId = id };
            var response = await _mediator.Send(command);
            return Ok();

        }
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
