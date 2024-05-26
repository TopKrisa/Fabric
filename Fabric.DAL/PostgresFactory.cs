using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Fabric.DAL;

public class PostgresFactory: IDesignTimeDbContextFactory<FabricDbContext>
{ 
    
    private readonly string _connectionString;

    public PostgresFactory(string connectionString)
    {
        _connectionString = connectionString;
    }
    
    public FabricDbContext CreateDbContext(string[] args)
    {
        var optionsBuilder = new DbContextOptionsBuilder<FabricDbContext>();
        optionsBuilder.UseNpgsql(_connectionString);

        return new FabricDbContext(optionsBuilder.Options);
    }
}