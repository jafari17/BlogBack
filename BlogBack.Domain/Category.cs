using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogBack.Domain
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string TitleCategory { get; set; }
        public string DescriptionCategory { get; set; }

         //public ICollection<Post> posts { get; }
    }
}
