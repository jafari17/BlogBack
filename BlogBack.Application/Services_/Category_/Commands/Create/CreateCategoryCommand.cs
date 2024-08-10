using BlogBack.Application.ViewModels;
using BlogBack.Domain;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogBack.Application.Services_.Category_.Commands.Create
{
    public class CreateCategoryCommand : IRequest<bool>
    {
        public CategoryDto categoryDto { get; set; }
    }
}
