using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace BlogBack.Application.ViewModels
{
    public class CategoryDto
    {
        public int CategoryId { get; set; }
        public string TitleCategory { get; set; }
        public string? DescriptionCategory { get; set; }



        //public int PostId { get; set; }
        //public PostDto Post { get; set; }

        //public ICollection<PostDto> posts { get; set; }
    }
}
