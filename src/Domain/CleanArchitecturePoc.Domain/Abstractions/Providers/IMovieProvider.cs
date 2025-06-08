using CleanArchitecturePoc.Domain.Models;

namespace CleanArchitecturePoc.Domain.Abstractions.Providers;

public interface IMovieProvider
{
    Task<IEnumerable<Movie>> GetMoviesAsync(CancellationToken cancellationToken = default);
}