namespace CleanArchitecturePoc.Models.Dtos;

public record MovieDto
{
    public required string Title { get; init; }
    
    public double Rating { get; init; }
}