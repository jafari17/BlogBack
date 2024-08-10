using AutoMapper;
using BlogBack.Application.Contracts;
using BlogBack.Application.ViewModels;
using BlogBack.Domain;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogBack.Application.Services_.Post_.Commands.Create
{
    public class CreatePostCommandHandler : IRequestHandler<CreatePostCommand, bool>
    {
        private readonly IMapper _mapper;
        private readonly IPostRepository _postRepository;
        private readonly ICategoryRepository _categoryRepository;
        private readonly ILabelRepository _labelRepository;



        public CreatePostCommandHandler( IMapper mapper, IPostRepository candlestickRepository, ICategoryRepository categoryRepository, ILabelRepository labelRepository)
        {
            _mapper = mapper;
            _postRepository = candlestickRepository;
            _categoryRepository = categoryRepository;
            _labelRepository = labelRepository;

        }
        public async Task<bool> Handle(CreatePostCommand request, CancellationToken cancellationToken)
        {
            //LabelDto labelDto = new LabelDto()
            //{
            //    LabelName = request.LabelName,
            //};
            //var label = _mapper.Map<Label>(labelDto);
            
            //await _labelRepository.AddLabelAsync(label);


            var category = await _categoryRepository.CategoryByIdAsync(request.CategoryId);
            var categoryDto = _mapper.Map<CategoryDto>(category);

            PostDto postdto = new PostDto()
            {
                Title = request.Title,
                Description = request.Description,
                Active = request.Active,

                CategoryId =  request.CategoryId,
            };

            var Post = _mapper.Map<Post>(postdto);
            await _postRepository.AddPostAsync(Post);
            await _postRepository.SaveChangesAsync();
            return await Task.FromResult(true);
        }
    }
}
