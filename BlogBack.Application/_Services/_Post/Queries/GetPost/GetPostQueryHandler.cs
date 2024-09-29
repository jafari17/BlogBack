using AutoMapper;
using BlogBack.Application.Contracts;
using BlogBack.Application.ViewModels;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogBack.Application._Services._Post.Queries.GetPost
{
    public class GetPostQueryHandler : IRequestHandler<GetPostQuery, IEnumerable<PostDto>>
    {
        private readonly IPostRepository _postRepository;
        private readonly IMapper _mapper;
        public GetPostQueryHandler(IPostRepository  postRepository, IMapper mapper)
        {
            _postRepository = postRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<PostDto>> Handle(GetPostQuery request, CancellationToken cancellationToken)
        {
            var ListPost = await _postRepository.GetListPostAsync(); 
            var ListPostDto = _mapper.Map<List<PostDto>>(ListPost);

            return ListPostDto;

        }
    }
}
