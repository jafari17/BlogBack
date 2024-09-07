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
        public int  PostId { get; set; }
        public string? UserId { get; set; }

        public string Title { get; set; }
         public virtual ICollection<Label> Labels { get; set; }

        public string Description { get; set; }
        public bool? Active { get; set; }
 
         public string? CategoryTitle { get; set; }
        public string PostDirectory { get; set; }



    }
}
