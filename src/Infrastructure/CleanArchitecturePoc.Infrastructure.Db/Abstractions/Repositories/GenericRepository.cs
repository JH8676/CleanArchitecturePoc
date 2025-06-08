using CleanArchitecturePoc.Domain.Abstractions.Repositories;
using CleanArchitecturePoc.Infrastructure.Abstractions.Entities;
using CleanArchitecturePoc.Infrastructure.Abstractions.Mappers;
using Microsoft.EntityFrameworkCore;

namespace CleanArchitecturePoc.Infrastructure.Abstractions.Repositories;

public class GenericRepository<TModel, TEntity> : IGenericRepository<TModel>
    where TModel : class
    where TEntity : BaseEntity
{
    private readonly MyDbContext _myDbContext;
    private readonly IMapper<TModel, TEntity> _mapper;
    private readonly DbSet<TEntity> _dbSet;
    
    protected DbSet<TEntity> DbSet => _dbSet;
    
    protected GenericRepository(MyDbContext myDbContext, IMapper<TModel, TEntity> mapper)
    {
        _myDbContext = myDbContext;
        _mapper = mapper;
        _dbSet = myDbContext.Set<TEntity>();
    }
    
    public virtual Task<IEnumerable<TModel>> GetAllAsync(CancellationToken cancellationToken = default)
    {
        return Task.FromResult(_dbSet.Select(_mapper.MapToModel));
    }
}