using Fabric.DAL.Abstractions;
using Fabric.DAL.Abstractions.Model;
using Fabric.DAL.Abstractions.Repository;
using Fabric.DAL.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Fabric.DAL;

public static class DbContextExtensionsDependencyInjection
{
    public static IServiceCollection RegisterDataBase(this IServiceCollection services)
    {
        var connectionString = "host=127.0.0.1;port=5432;database=test;user id=postgres;password=sql_server123";
        var context =
            new PostgresFactory(connectionString)
                .CreateDbContext(new string[]{ });

        context.Database.EnsureCreated();
        
        services.AddDbContext<IFabricDbContext, FabricDbContext>(opt =>
        {
            opt.UseNpgsql(connectionString);
            opt.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
        });
        
        services.AddScoped<IFabricDbContext, FabricDbContext>();
        services.AddScoped<IAccessoryRepository, AccessoryRepository>();
        services.AddScoped<IProductRepository, ProductRepository>();
            
        return services;
    }
}