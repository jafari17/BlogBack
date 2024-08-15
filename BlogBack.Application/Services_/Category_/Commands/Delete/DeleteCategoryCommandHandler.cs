using AutoMapper;
using BlogBack.Application.Contracts;
using BlogBack.Application.Services_.Category_.Commands.Create;
using BlogBack.Domain;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogBack.Application.Services_.Category_.Commands.Delete
{
    public class DeleteCategoryCommandHandler : IRequestHandler<DeleteCategoryCommand, bool>
    {
         private readonly ICategoryRepository _categoryRepository;

        public DeleteCategoryCommandHandler(  ICategoryRepository categoryRepository)
        {
             _categoryRepository = categoryRepository;
        }
        public async Task<bool> Handle(DeleteCategoryCommand request, CancellationToken cancellationToken)
        {
            await _categoryRepository.DeleteByIdAsync(request.CategoryId);
            await _categoryRepository.SaveChangesAsync();
            return await Task.FromResult(true);
        }
    }
}
 
