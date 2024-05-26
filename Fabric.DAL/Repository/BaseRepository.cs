using Fabric.DAL.Abstractions.Model;
using Microsoft.EntityFrameworkCore;

namespace Fabric.DAL.Repository;

public class BaseRepository<TEntity> where TEntity : BaseEntity
{
    private readonly DbSet<TEntity> _dbSet;

    protected BaseRepository(DbSet<TEntity> dbSet)
    {
        _dbSet = dbSet;
    }

    public DbSet<TEntity> DbSet => _dbSet;
}