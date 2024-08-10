using AutoMapper;
using BlogBack.Application.Contracts;
using BlogBack.Application.Services_.Post_.Queries.GetPost;
using BlogBack.Application.ViewModels;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogBack.Application.Services_.Category_.Queries.GetCategory
{
    public class GetCategoryQueryHandler : IRequestHandler<GetCategoryQuery, IEnumerable<CategoryDto>>
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly IMapper _mapper;
        public GetCategoryQueryHandler(ICategoryRepository categoryRepository, IMapper mapper)
        {
            _categoryRepository = categoryRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<CategoryDto>> Handle(GetCategoryQuery request, CancellationToken cancellationToken)
        {
            var ListPost = await _categoryRepository.GetListCategoryAsync();

            var ListPostDto = _mapper.Map<List<CategoryDto>>(ListPost);

            return ListPostDto;

        }
    }
}
