using Microsoft.Extensions.DependencyInjection;
using Simple.BL.Services.Abstractions;
using Simple.BL.Services.Concretes;

namespace Simple.BL;

public static class ServiceConfiguration
{
    public static void AddServiceConfiguration(this IServiceCollection Service)
    {
        Service.AddScoped<ICartItemService,CartItemService>();
    }
}
