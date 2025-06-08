using CleanArchitecturePoc.Domain.Models;
using CleanArchitecturePoc.Infrastructure.Abstractions.Mappers;
using CleanArchitecturePoc.Infrastructure.Abstractions.Repositories;
using CleanArchitecturePoc.Infrastructure.Entities;

namespace CleanArchitecturePoc.Infrastructure.Repositories;

public class MovieRepository : GenericRepository<Movie, MovieEntity>
{
    private readonly IMapper<Movie, MovieEntity> _mapper;

    public MovieRepository(MyDbContext myDbContext, IMapper<Movie, MovieEntity> mapper)
        : base(myDbContext, mapper)
    {
        _mapper = mapper;
    }
    
    public override Task<IEnumerable<Movie>> GetAllAsync(CancellationToken cancellationToken = default)
    {
        IEnumerable<Movie> movies = new List<Movie>
        {
            // new Movie
            // {
            //     Title = "The Shawshank Redemption",
            //     Rating = 9.3,
            // }
        };
        return Task.FromResult(movies);
    }
}