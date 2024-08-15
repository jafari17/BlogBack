using BlogBack.Application.ViewModels;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogBack.Application.Services_.Post_.Queries.GetPostById
{
    public class GetPostByIdQuery : IRequest<PostDto>
    {
        public int PostId { get; set; }
    }
}
