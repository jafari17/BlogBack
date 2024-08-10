using AutoMapper;
using BlogBack.Application.Contracts;
using BlogBack.Application.Services_.Post_.Commands.Create;
using BlogBack.Domain;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogBack.Application.Services_.Category_.Commands.Create
{
    public class CreateCategoryCommandHandler : IRequestHandler<CreateCategoryCommand, bool>
    {
        private readonly IMapper _mapper;
        private readonly ICategoryRepository _categoryRepository;

        public CreateCategoryCommandHandler(IMapper mapper, ICategoryRepository categoryRepository)
        {
            _mapper = mapper;
            _categoryRepository = categoryRepository;
        }
        public async Task<bool> Handle(CreateCategoryCommand request, CancellationToken cancellationToken)
        {
            var category = _mapper.Map<Category>(request.categoryDto);
            await _categoryRepository.AddCategoryAsync(category);
            await _categoryRepository.SaveChangesAsync();
            return await Task.FromResult(true);
        }
    }
}
