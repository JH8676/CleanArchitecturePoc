namespace CleanArchitecturePoc.Application.Contracts.Abstractions.Services;

public interface IGenericService<TDto>
    where TDto : class
{
    public Task<IEnumerable<TDto>> GetAllAsync(CancellationToken cancellationToken = default);
}