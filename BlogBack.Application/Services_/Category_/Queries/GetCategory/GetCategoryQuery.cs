using BlogBack.Application.ViewModels;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogBack.Application.Services_.Category_.Queries.GetCategory
{
    public class GetCategoryQuery : IRequest<IEnumerable<CategoryDto>>
    {
    }
}
