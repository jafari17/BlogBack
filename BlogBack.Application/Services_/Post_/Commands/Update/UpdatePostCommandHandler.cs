using AutoMapper;
using BlogBack.Application.Contracts;
using BlogBack.Application.Services_.Post_.Commands.Create;
using BlogBack.Application.ViewModels;
using BlogBack.Domain;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogBack.Application.Services_.Post_.Commands.Update
{
    internal class UpdatePostCommandHandler : IRequestHandler<UpdatePostCommand, bool>
    {
        private readonly IMapper _mapper;
        private readonly IPostRepository _postRepository;
        private readonly ICategoryRepository _categoryRepository;
        //private readonly ILabelRepository _labelRepository;

        public UpdatePostCommandHandler(IMapper mapper, IPostRepository candlestickRepository, ICategoryRepository categoryRepository)
        {
            _mapper = mapper;
            _postRepository = candlestickRepository;
            _categoryRepository = categoryRepository;

        }
        public async Task<bool> Handle(UpdatePostCommand request, CancellationToken cancellationToken)
        {
  
            //var category = await _categoryRepository.CategoryByIdAsync(request.PostDto.CategoryId);
            //var categoryDto = _mapper.Map<CategoryDto>(category);

 
            var post = _mapper.Map<Post>(request.PostDto);
            await _postRepository.UpdatePostAsync(post);
            await _postRepository.SaveChangesAsync();
            return await Task.FromResult(true);
        }
    }
}
