using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Plumberz.DAL.Repositories.Abstractions;
using Plumberz.DAL.Repositories.Concretes;

namespace Plumberz.DAL.Configurations.Repository;

public static class RepoConfig 
{
    public static void AddRepoConfig(this IServiceCollection services)
    {
        services.AddScoped<ITechnicianRepository, TechnicianRepository>();
    }
}
