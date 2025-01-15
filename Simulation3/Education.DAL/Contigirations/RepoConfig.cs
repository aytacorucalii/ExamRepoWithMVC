using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Education.DAL.Repositories.Abstractions;
using Education.DAL.Repositories.Concretes;
using Microsoft.Extensions.DependencyInjection;

namespace Education.DAL.Contigirations;

public static class RepoConfig
{
    public static void AddRepoConfig(this IServiceCollection services)
    {
        services.AddScoped<INewsRepository, NewsRepository>();
    }
    
}
