namespace CleanArchitecturePoc.Domain.Models;

public class Movie
{
    public required string Title { get; set; }
    
    public double Rating { get; set; }
    
    public string? ExternalId { get; set; }
}