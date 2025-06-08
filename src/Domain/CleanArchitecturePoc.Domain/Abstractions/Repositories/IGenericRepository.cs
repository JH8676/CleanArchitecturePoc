namespace CleanArchitecturePoc.Domain.Abstractions.Repositories;

public interface IGenericRepository<TModel>
    where TModel : class
{
    public Task<IEnumerable<TModel>> GetAllAsync(CancellationToken cancellationToken = default);
}