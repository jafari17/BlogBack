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
    public class CategoryRepository : ICategoryRepository
    {
        private readonly BlogBackDbContexts _context;
        public CategoryRepository(BlogBackDbContexts context)
        {
            _context = context;
        }
        public async Task AddCategoryAsync(Category category)
        {
            await _context.Category.AddAsync(category); 
        }

        public async Task<Category> CategoryByIdAsync(int id)
        {
            return _context.Category.First(x => x.CategoryId == id);
        }

        public async Task<IEnumerable<Category>> GetListCategoryAsync()
        {
            return await _context.Category.Include(x => x.posts).ToListAsync();
        }

        public void RemoveAllCategory()
        {
            _context.Category.ExecuteDelete();
        }

        public async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
