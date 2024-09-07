using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogBack.Application.Services_.Post_.Commands.Delete
{
    public class DeletePostCommand : IRequest<string>
    {
        public int PostId { get; set; }
    }
}
