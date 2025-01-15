using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Education.BL.Services.Abstractions;
using Education.BL.Services.Concretes;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Education.BL.Config;

public static class ServiceConfig 
{
    public static void AddServiceConfig(this IServiceCollection services)
    {
        services.AddScoped<INewsService, NewsService>(); 
    }
}
