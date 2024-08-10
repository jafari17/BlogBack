using BlogBack.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogBack.Application.Contracts
{
    public interface ILabelRepository
    {
        Task<IEnumerable<Label>> GetListLabelAsync();
        Task<Label> LabelByIdAsync(int id);
        Task AddLabelAsync(Label label);
        void removeAllLabel();
        Task SaveChangesAsync();
    }
}
