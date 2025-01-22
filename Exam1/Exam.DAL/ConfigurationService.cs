using Exam.Core.Models;
using Exam.DAL.Repository.Abstractions;
using Exam.DAL.Repository.Concretes;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam.DAL
{
    public static class ConfigurationService
    {
        public static void AddConfigurationService(this IServiceCollection services)
        {
            services.AddScoped<IRepository<Person>, Repository<Person>>();
            services.AddScoped<IRepository<Car>, Repository<Car>>();
        }
    }
}
