using AutoMapper;
using BlogBack.Application.Contracts;
using BlogBack.Application.Services_.Post_.Commands.Create;
using BlogBack.Application.ViewModels;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogBack.Application.Services_.Post_.Commands.Delete
{
    internal class DeletePostCommandHandler : IRequestHandler<DeletePostCommand, bool>
    {
        private readonly IMapper _mapper;
        private readonly IPostRepository _postRepository;
        //private readonly ICategoryRepository _categoryRepository;
        //private readonly ILabelRepository _labelRepository;



        public DeletePostCommandHandler(IMapper mapper, IPostRepository candlestickRepository)
        {
            _mapper = mapper;
            _postRepository = candlestickRepository;
 
        }
        public async Task<bool> Handle(DeletePostCommand request, CancellationToken cancellationToken)
        {
 

            //var Post = _mapper.Map<Post>(request.PostDto);
            await _postRepository.DeletePostByIdAsync(request.PostId);
            await _postRepository.SaveChangesAsync();
            return await Task.FromResult(true);
        }
    }
}
