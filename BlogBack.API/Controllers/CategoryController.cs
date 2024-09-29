using BlogBack.Application._Services._Category.Commands.Create;
using BlogBack.Application._Services._Category.Commands.Delete;
using BlogBack.Application._Services._Category.Queries.GetCategory;
using BlogBack.Application._Services._Post.Commands.Create;
using BlogBack.Application._Services._Post.Queries.GetPost;
using BlogBack.Application.ViewModels;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BlogBack.API.Controllers
{
    
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class CategoryController : Controller
    {
        private readonly IMediator _mediator;

        public CategoryController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [Authorize]
        [HttpGet]
        public async Task<IActionResult> AddCategory(string TitleCategory, string? DescriptionCategory )
        {
            CategoryDto categoryDto = new CategoryDto()
            {
                TitleCategory = TitleCategory,
                DescriptionCategory = DescriptionCategory
            };

            var command = new CreateCategoryCommand()
            {
                categoryDto = categoryDto
            };
            var response = await _mediator.Send(command);
            return Ok();
        }
        [Authorize]
        [HttpDelete]
        public async Task<IActionResult> DeleteCategory(int id)
        {
            var command = new DeleteCategoryCommand() { CategoryId = id };
            var response = await _mediator.Send(command);
            return Ok();
        }


         [HttpGet]
        public async Task<IActionResult> GetCategory()
        {
            var query = new GetCategoryQuery() { };
            var response = await _mediator.Send(query);
            return Ok(response);
        }

    }
}
