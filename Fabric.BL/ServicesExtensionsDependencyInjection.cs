using Fabric.BL.Services;
using Fabric.BL.Services.Implementations;
using Fabric.DAL.Abstractions.Repository;
using Microsoft.Extensions.DependencyInjection;
using Fabric.DAL;

namespace Fabric.BL;

public static class ServicesExtensionsDependencyInjection
{
    public static IServiceCollection AddServices(this IServiceCollection services)
    {
        services.RegisterDataBase();
        services.AddScoped<IAccessoryService, AccessoryService>();
        services.AddScoped<IProductService, ProductService>();

        return services;
    }
}