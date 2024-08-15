using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogBack.Domain
{
    public class Label
    {
         public string LabelName { get; set; } 
         public int PostId { get; set; }
         public Post Post { get; set; }
    }
}
