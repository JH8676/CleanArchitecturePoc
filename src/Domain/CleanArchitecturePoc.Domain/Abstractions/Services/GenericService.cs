using CleanArchitecturePoc.Application.Contracts.Abstractions.Services;
using CleanArchitecturePoc.Domain.Abstractions.Mappers;
using CleanArchitecturePoc.Domain.Abstractions.Repositories;

namespace CleanArchitecturePoc.Domain.Abstractions.Services;

public class GenericService<TModel, TDto>(
    IGenericRepository<TModel> repository, 
    IMapper<TModel, TDto> mapper) : IGenericService<TDto>
    where TModel : class
    where TDto : class
{
    protected IGenericRepository<TModel> Repository => repository;
    
    protected IMapper<TModel, TDto> Mapper => mapper;
    
    public virtual async Task<IEnumerable<TDto>> GetAllAsync(CancellationToken cancellationToken = default)
    {
        var movies = await repository.GetAllAsync(cancellationToken);
        return movies.Select(mapper.MapToDto);
    }
}