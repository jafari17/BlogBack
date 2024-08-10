using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace BlogBack.Domain
{
    public class Post
    {
 
        public int PostId { get; set; }
        public string Title { get; set; }
        public int CategoryId { get; set; }
        public ICollection<Label> Labels { get; set; }

        public string Description { get; set; }
        public bool? Active { get; set; }

        //List<Label> Labels { get; set; }
        //[ForeignKey("CategoryId")]
        //public virtual Category? Category { get; set; }
         public Category Category { get; set; }


    }
}
