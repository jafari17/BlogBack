using BlogBack.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogBack.Application.Contracts
{
    public interface IPostRepository
    {
        Task<IEnumerable<Post>> GetListPostAsync();
        Task<Post> PostByIdAsync(int id);

        Task AddPostAsync(Post post);
        void removeAllPost();
        Task SaveChangesAsync();
    }
}
