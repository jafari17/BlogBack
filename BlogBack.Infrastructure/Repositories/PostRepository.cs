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

        public async Task DeletePostByIdAsync(int id)
        {
            var post = await GetPostByIdAsync(id);
            _context.Post.Remove(post);
        }

        public async Task<IEnumerable<Post>> GetListPostAsync()
        {
            var c = await _context.Post.Include(l => l.Labels).ToListAsync();

            return c;


 
        }

        public async Task<Post> GetPostByIdAsync(int id)
        {
            return _context.Post.Include(l => l.Labels).First(x => x.PostId == id);

        }

        public void removeAllPost()
        {
            _context.Post.ExecuteDelete();
        }

        public async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }

        //public async Task UpdatePostAsync(Post post)
        //{
 
        //    _context.Entry(post).State = EntityState.Modified;
        //}

        public async Task UpdatePostAsync(Post post)
        {
            //_context.Attach(post);

            //var originalLabels = await _context.Label.Where(x => x.PostId == post.PostId).ToListAsync();

            //foreach (var label in post.Labels.Where(l => originalLabels == null || !originalLabels.Contains(l)))
            //{
            //    label.PostId = post.PostId;
            //    label.Post = post;
            //    //_context.Entry(label).State = EntityState.Added;
            //    await _context.Label.AddAsync(label);
            //}

            //foreach (var label in originalLabels.Where(l => !post.Labels.Contains(l)))
            //{
            //    _context.Entry(label).State = EntityState.Deleted;
            //}

            _context.Entry(post).State = EntityState.Modified;

         }

    }
}
 
