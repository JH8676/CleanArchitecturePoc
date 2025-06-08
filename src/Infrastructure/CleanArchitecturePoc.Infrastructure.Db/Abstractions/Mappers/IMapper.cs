using CleanArchitecturePoc.Infrastructure.Abstractions.Entities;

namespace CleanArchitecturePoc.Infrastructure.Abstractions.Mappers;

public interface IMapper<TModel, TEntity>
    where TModel : class
    where TEntity : BaseEntity
{
    TEntity MapToEntity(TModel model);
    
    TModel MapToModel(TEntity entity);
}