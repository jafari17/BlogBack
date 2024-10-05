using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogBack.Application.ViewModels
{
    public class UserBlog
    {
        public string UserId { get; set; } 
        public string? FirstName { get; set; }
        public string? LastName { get; set; } 
        public string? Description { get; set; }
     }
}
