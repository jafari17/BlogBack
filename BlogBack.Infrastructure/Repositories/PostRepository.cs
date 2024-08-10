using BlogBack.Application.Contracts;
using BlogBack.Domain;
using BlogBack.Infrastructure.DbContexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogBack.Infrastructure.Repositories
{
    public class PostRepository : IPostRepository
    {
        private readonly BlogBackDbContexts _context;
        public PostRepository(BlogBackDbContexts context)
        {
            _context = context;
        }
        public async Task AddPostAsync(Post post)
        {
            await _context.Post.AddAsync(post);

        }

        public async Task<IEnumerable<Post>> GetListPostAsync()
        {
            var c = await _context.Post.Include(x => x.Category).ToListAsync();

            return c;


 
        }

        public async Task<Post> PostByIdAsync(int id)
        {
            return _context.Post.Include(x => x.Category).First(x => x.PostId == id);

        }

        public void removeAllPost()
        {
            _context.Post.ExecuteDelete();
        }

        public async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
 
