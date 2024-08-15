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
        Task<Post> GetPostByIdAsync(int id);

        Task AddPostAsync(Post post);
        Task UpdatePostAsync(Post post);
        Task DeletePostByIdAsync(int id);

        void removeAllPost();
        Task SaveChangesAsync();
    }
}
