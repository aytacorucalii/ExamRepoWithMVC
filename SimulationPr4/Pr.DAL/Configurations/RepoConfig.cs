using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.Extensions.DependencyInjection;
using Pr.DAL.Repositories.Abstractions;
using Pr.DAL.Repositories.Concretes;

namespace Pr.DAL.Configurations
{
    public static class RepoConfig
    {
        public static void AddRepoConfig(this IServiceCollection services)
        {
            services.AddScoped<IDoctorRepository, DoctorRepository>();
            services.AddScoped<IDepartmentRepository, DepartmentRepository>();
        }
      
    }
}
