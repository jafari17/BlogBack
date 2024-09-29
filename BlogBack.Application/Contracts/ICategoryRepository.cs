using BlogBack.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogBack.Application.Contracts
{
    public interface ICategoryRepository
    {
        Task<IEnumerable<Category>> GetListCategoryAsync();
        Task AddCategoryAsync(Category category);
        Task<Category> CategoryByIdAsync(int id);
        Task DeleteByIdAsync(int id);
        void RemoveAllCategory();
        Task SaveChangesAsync();
    }
}
