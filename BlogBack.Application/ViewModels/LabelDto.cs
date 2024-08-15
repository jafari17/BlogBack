using BlogBack.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogBack.Application.ViewModels
{
    public class LabelDto
    {
         public string LabelName { get; set; }

         public int PostId { get; set; }
    }
}
