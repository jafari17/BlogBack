﻿using BlogBack.Application.ViewModels;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogBack.Application.Services_.Post_.Commands.Update
{
    public class UpdatePostCommand : IRequest<bool>
    {
        public PostDto PostDto { get; set; }

    }
}
