using BlogBack.Application.ViewModels;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogBack.Application.Services_.Post_.Commands.Create
{
    public class CreatePostCommand : IRequest<bool>
    {
        public string Title { get; set; }
        public int CategoryId { get; set; }
         public string Description { get; set; }
        public bool? Active { get; set; }

        public string LabelName { get; set; }



    }
}
