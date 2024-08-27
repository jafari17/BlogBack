using AutoMapper;
using BlogBack.Application.Contracts;
using BlogBack.Application.Services_.Post_.Queries.GetPostById;
using BlogBack.Application.ViewModels;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogBack.Application.Services_.Post_.Queries.GetListPostByUserId
{
    public class GetListPostByUserIdQueryHandler : IRequestHandler<GetListPostByUserIdQuery, IEnumerable<PostDto>>
    {
        private readonly IPostRepository _postRepository;
        private readonly IMapper _mapper;
        public GetListPostByUserIdQueryHandler(IPostRepository postRepository, IMapper mapper)
        {
            _postRepository = postRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<PostDto>> Handle(GetListPostByUserIdQuery request, CancellationToken cancellationToken)
        {
            var ListPost = await _postRepository.GetListPostByUserIdAsync(request.UserId);
            var ListPostDto = _mapper.Map<List<PostDto>>(ListPost); 
            return ListPostDto; 
        }
    }
}
