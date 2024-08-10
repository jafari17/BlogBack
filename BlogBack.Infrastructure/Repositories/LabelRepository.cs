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
    public class LabelRepository : ILabelRepository
    {

        private readonly BlogBackDbContexts _context;
        public LabelRepository(BlogBackDbContexts context)
        {
            _context = context;
        }




        public async Task AddLabelAsync(Label label)
        {
            await _context.Label.AddAsync(label);
        }

        public async Task<IEnumerable<Label>> GetListLabelAsync()
        {
            var c = await _context.Label.Include(x => x.Post).ToListAsync();

            return c;
        }

        public async  Task<Label> LabelByIdAsync(int id)
        {
            return _context.Label.Include(x => x.Post).First(x => x.LabelId == id);
        }

        public void removeAllLabel()
        {
            _context.Post.ExecuteDelete();
        }

        public async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
