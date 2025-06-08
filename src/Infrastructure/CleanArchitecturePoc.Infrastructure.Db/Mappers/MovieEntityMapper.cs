using CleanArchitecturePoc.Domain.Models;
using CleanArchitecturePoc.Infrastructure.Abstractions.Mappers;
using CleanArchitecturePoc.Infrastructure.Entities;
using CleanArchitecturePoc.Models.Dtos;

namespace CleanArchitecturePoc.Infrastructure.Mappers;

public class MovieEntityMapper : IMapper<Movie, MovieEntity>
{
    public MovieEntity MapToEntity(Movie model)
    {
        return new MovieEntity
        {
            Title = model.Title,
            Rating = model.Rating,
            ExternalId = model.ExternalId,
        };
    }
    
    public Movie MapToModel(MovieEntity entity)
    {
        return new Movie
        {
            Title = entity.Title,
            Rating = entity.Rating,
            ExternalId = entity.ExternalId,
        };
    }
}