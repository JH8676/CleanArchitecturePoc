using CleanArchitecturePoc.Domain.Abstractions.Mappers;
using CleanArchitecturePoc.Domain.Models;
using CleanArchitecturePoc.Models.Dtos;

namespace CleanArchitecturePoc.Domain.Mappers;

public class MovieMapper : IMapper<Movie, MovieDto>
{
    public MovieDto MapToDto(Movie model)
    {
        return new MovieDto
        {
            Title = model.Title,
            Rating = model.Rating,
        };
    }
    
    public Movie MapToModel(MovieDto dto)
    {
        return new Movie
        {
            Title = dto.Title,
            Rating = dto.Rating,
        };
    }
}