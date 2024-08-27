using BlogBack.Domain;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
 
namespace BlogBack.Infrastructure.DbContexts
{
    public class BlogBackDbContexts : IdentityDbContext
    {
        public BlogBackDbContexts()
        {
        }

        public BlogBackDbContexts
           (DbContextOptions<BlogBackDbContexts> options)
           : base(options)
        {

        }

        public virtual DbSet<Post> Post { get; set; } = null!;
        public virtual DbSet<Category> Category { get; set; } = null!;
        public virtual DbSet<Label> Label { get; set; } = null!;




        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            

            base.OnModelCreating(modelBuilder);

            ConfigPost(modelBuilder);
        }

        private void ConfigPost(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Post>().HasKey(t => t.PostId);

            modelBuilder.Entity<Category>().HasKey(t => t.CategoryId);

            modelBuilder.Entity<Label>().HasKey(t => t.LabelId);




            //modelBuilder.Entity<Category>()
            //    .HasMany(c => c.posts)
            //    .WithOne(p => p.Category)
            //    .HasForeignKey(p => p.CategoryId);

            modelBuilder.Entity<Post>()
                .HasMany(c => c.Labels)
                .WithOne(p => p.Post)
                .HasForeignKey(p => p.PostId);


            //modelBuilder.Entity<Label>(entity =>
            //{
            //    entity.HasKey(e => new { e.PostId, e.LabelName });
            //});




        }
    }
}
