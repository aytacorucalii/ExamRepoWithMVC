using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Pr.BL.Services.Abstractions;
using Pr.BL.Services.Concretes;

namespace Pr.BL.Configurations.ServiceConfig
{
    public static class Config
    {
        public static void AddConfig(this IServiceCollection services)
        {
            services.AddScoped<IDepartmentService, DepartmentService>();
            services.AddScoped<IDoctorService, DoctorService>();
        }
    }
}
