using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace BlogBack.Domain
{
    public class ApplicationUser : IdentityUser
    {
        public string? FullName { get; set; }
 
        public DateTime? DateOfBirth { get; set; }

        //[JsonIgnore]
        //[IgnoreDataMember]
        public virtual ICollection<Post> Posts { get; set; }

    }
}
