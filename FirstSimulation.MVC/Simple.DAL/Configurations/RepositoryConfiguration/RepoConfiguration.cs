using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Simple.DAL.Repositories.Abstractions;
using Simple.DAL.Repositories.Concretes;

namespace Simple.DAL.Configurations.RepositoryConfiguration;

public static class RepoConfiguration
{
    public static void AddRepoConfiguration(this IServiceCollection Service)
    {
        Service.AddScoped<ICartItemReadReository, CartItemReadRepository>();
        Service.AddScoped<ICartItemWriteReository, CartItemWriteRepository>();
    }
}
