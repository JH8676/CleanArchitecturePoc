using CleanArchitecturePoc.Domain.Abstractions.Providers;
using CleanArchitecturePoc.Domain.Models;

namespace CleanArchitecturePoc.Infrastructure.IMDb;

public class ImdbMovieProvider : IMovieProvider
{
    public async Task<IEnumerable<Movie>> GetMoviesAsync(CancellationToken cancellationToken = default)
    {
        await Task.Delay(500, cancellationToken);

        IEnumerable<Movie> result = new List<Movie>()
        {
            new Movie
            {
                Title = "The Shawshank Redemption",
                Rating = 9.3,
                ExternalId = Guid.NewGuid().ToString(),
            }
        };
        
        return result;
    }
}