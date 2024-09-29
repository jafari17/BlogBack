using AutoMapper;
using BlogBack.Application.Contracts;
using BlogBack.Application._Services._Post.Commands.Create;
using BlogBack.Application.ViewModels;
using BlogBack.Domain;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogBack.Application._Services._Post.Commands.Delete
{
    internal class DeletePostCommandHandler : IRequestHandler<DeletePostCommand, string>
    {
        private readonly IMapper _mapper;
        private readonly IPostRepository _postRepository;
        //private readonly ICategoryRepository _categoryRepository;
        //private readonly ILabelRepository _labelRepository;



        public DeletePostCommandHandler(IMapper mapper, IPostRepository candlestickRepository )
        {
            _mapper = mapper;
            _postRepository = candlestickRepository;
 
        }
        public async Task<string> Handle(DeletePostCommand request, CancellationToken cancellationToken)
        {
            try
            {
                var post = await _postRepository.GetPostByIdAsync(request.PostId);

                await _postRepository.DeletePostByIdAsync(request.PostId);
                await _postRepository.SaveChangesAsync();
                return await Task.FromResult(post.PostDirectory);
            }
            catch (Exception)
            {
                return await Task.FromResult(string.Empty);
                throw;
            }


            
        }
    }
}
