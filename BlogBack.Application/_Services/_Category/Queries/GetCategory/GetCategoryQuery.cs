using BlogBack.Application.ViewModels;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogBack.Application._Services._Category.Queries.GetCategory
{
    public class GetCategoryQuery : IRequest<IEnumerable<CategoryDto>>
    {
    }
}
