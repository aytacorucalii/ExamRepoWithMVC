using Microsoft.Extensions.DependencyInjection;
using Plumberz.BL.Services.Abstractions;
using Plumberz.BL.Services.Concretes;

namespace Plumberz.BL.Configurations;

public static class ServiceConfig
{
    public static void AddServiceConfig(this IServiceCollection services)
    {
        services.AddScoped<ITechnicianService, TechnicianService>();
    }
}
