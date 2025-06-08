using CleanArchitecturePoc.Domain.Abstractions.Mappers;
using CleanArchitecturePoc.Domain.Abstractions.Providers;
using CleanArchitecturePoc.Domain.Abstractions.Repositories;
using CleanArchitecturePoc.Domain.Abstractions.Services;
using CleanArchitecturePoc.Domain.Models;
using CleanArchitecturePoc.Models.Dtos;

namespace CleanArchitecturePoc.Domain.Services;

public class MovieService : GenericService<Movie, MovieDto>
{
    private readonly IMovieProvider _movieProvider;

    public MovieService(
        IGenericRepository<Movie> repository,
        IMapper<Movie, MovieDto> mapper,
        IMovieProvider movieProvider)
        : base(repository, mapper)
    {
        _movieProvider = movieProvider;
    }

    public override async Task<IEnumerable<MovieDto>> GetAllAsync(CancellationToken cancellationToken = default)
    {
        var movies = await _movieProvider.GetMoviesAsync(cancellationToken);
        return movies.Select(Mapper.MapToDto);
    }
}