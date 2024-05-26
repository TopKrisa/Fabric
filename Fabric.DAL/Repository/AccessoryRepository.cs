using Fabric.DAL.Abstractions;
using Fabric.DAL.Abstractions.Model;
using Fabric.DAL.Abstractions.Repository;
using Microsoft.EntityFrameworkCore;

namespace Fabric.DAL.Repository;

internal class AccessoryRepository : BaseRepository<Accessory>, IAccessoryRepository
{
    private readonly IFabricDbContext _dbContext;


    public AccessoryRepository(IFabricDbContext dbContext)
        : base(dbContext.Accessories)
    {
        _dbContext = dbContext;
    }
}