using Fabric.DAL.Abstractions;
using Fabric.DAL.Abstractions.Model;
using Fabric.DAL.Configurations;
using Microsoft.EntityFrameworkCore;

namespace Fabric.DAL;

public class FabricDbContext : DbContext, IFabricDbContext
{
    public FabricDbContext(DbContextOptions<FabricDbContext> options)
        : base(options)
    {
        
    }
    
    public DbSet<Product> Products { get; set; }
    public DbSet<Accessory> Accessories { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new ProductEntityTypeConfiguration());
        modelBuilder.ApplyConfiguration(new AccessoryEntityTypeConfiguration());
        
        base.OnModelCreating(modelBuilder);
    }
}