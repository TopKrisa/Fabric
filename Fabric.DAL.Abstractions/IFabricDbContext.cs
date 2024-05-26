using Fabric.DAL.Abstractions.Model;
using Microsoft.EntityFrameworkCore;

namespace Fabric.DAL.Abstractions;

public interface IFabricDbContext
{
    DbSet<Product> Products { get; set; }
    
    DbSet<Accessory> Accessories { get; set; }
}