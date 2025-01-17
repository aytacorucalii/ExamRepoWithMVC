using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using S.BL.Services.Abstractions;
using S.BL.Services.Concretes;

namespace S.BL.Configurations
{
    public static class ServiceConfig
    {
        public static void AddServiceConfig(this IServiceCollection services )
        {
            services.AddScoped<IAtractionService, AtractionService>();
            services.AddScoped<ICategoryService, CategoryService>();
        }
    }
}
