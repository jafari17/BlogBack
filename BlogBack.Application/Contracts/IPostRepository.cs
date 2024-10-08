﻿using BlogBack.Domain;
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
        Task<IEnumerable<Post>> GetListPostByUserIdAsync(string userId);
        Task<Post> GetPostByIdAsync(int id);
        Task AddPostAsync(Post post);
        Task UpdatePostAsync(Post post);
        Task DeletePostByIdAsync(int id);
        Task<IEnumerable<Post>> GetListPostDirectorytAsync();
        Task<IEnumerable<string>> GetListUrlImageByPostDirectoryAsync(string postDirectory);
         
        void removeAllPost();
        Task SaveChangesAsync();
    }
}
