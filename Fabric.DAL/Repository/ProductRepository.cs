using Fabric.DAL.Abstractions;
using Fabric.DAL.Abstractions.Model;
using Fabric.DAL.Abstractions.Repository;
using Microsoft.EntityFrameworkCore;

namespace Fabric.DAL.Repository;

internal class ProductRepository : BaseRepository<Product>, IProductRepository
{
    private readonly IFabricDbContext _dbContext;
    
    public ProductRepository(IFabricDbContext fabricDbContext) 
        : base(fabricDbContext.Products)
    {
        _dbContext = fabricDbContext;
    }
    
    
}