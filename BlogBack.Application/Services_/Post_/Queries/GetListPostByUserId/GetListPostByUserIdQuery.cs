﻿using BlogBack.Application.ViewModels;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogBack.Application.Services_.Post_.Queries.GetListPostByUserId
{
     
    public class GetListPostByUserIdQuery : IRequest<IEnumerable<PostDto>>
    {
        public string UserId { get; set; }
    }
}
