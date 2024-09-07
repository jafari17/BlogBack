using BlogBack.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogBack.Application.ViewModels
{

    public class PostDto
    {
        public int PostId { get; set; }
        public string Title { get; set; }
        public string? UserId { get; set; }

        public ICollection<LabelDto>? Labels { get; set; }
        public string? Description { get; set; }
        public bool? Active { get; set; }
        //public int CategoryId { get; set; }

        public string? CategoryTitle { get; set; }
        public string PostDirectory { get; set; }

    }










    //public class PostDto
    //{
    //    public int PostId { get; set; }
    //    public string Title { get; set; }
    //    //public int CategoryId { get; set; }
    //    //List<Label> Labels { get; set; }
    //    public string Description { get; set; }
    //    public bool? Active { get; set; }



    //    //[ForeignKey("CategoryId")]
    //    //public virtual Category? Category { get; set; }



    //    public int CategoryId { get; set; }
    //    public CategoryDto Category { get; set; }


    //}
}
