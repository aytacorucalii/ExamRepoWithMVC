using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using S.DAL.Repositories.Abstractions;
using S.DAL.Repositories.Concretes;

namespace S.DAL.Configrations
{
    public static class RepoConfig
    {
        public static void AddRepoConfig(this IServiceCollection services)
        {
            services.AddScoped<IAtractionRepository, AtractionRepository>();
            services.AddScoped<ICategoryRepository, CategoryRepository>();
        }
    }
}
