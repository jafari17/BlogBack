using BlogBack.Application.Services_.Category_.Commands.Create;
using BlogBack.Application.Services_.Category_.Commands.Delete;
using BlogBack.Application.Services_.Category_.Queries.GetCategory;
using BlogBack.Application.Services_.Post_.Commands.Create;
using BlogBack.Application.Services_.Post_.Queries.GetPost;
using BlogBack.Application.ViewModels;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BlogBack.API.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class CategoryController : Controller
    {
        private readonly IMediator _mediator;

        public CategoryController(IMediator mediator)
        {
            _mediator = mediator;
        }


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
