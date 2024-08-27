using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlogBack.Application.Contracts;
using BlogBack.Infrastructure.DbContexts;
using BlogBack.Infrastructure.Repositories;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;



namespace BlogBack.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services)
        {

            services.AddDbContext<BlogBackDbContexts>(option =>
            {
                option.UseSqlite("Data Source=BlogBackDb.db");

            }, ServiceLifetime.Scoped);



            services.AddScoped<IPostRepository, PostRepository>();
            services.AddScoped<ICategoryRepository, CategoryRepository>();
            //services.AddScoped<ILabelRepository, LabelRepository>();



            return services;
        }
    }
}
