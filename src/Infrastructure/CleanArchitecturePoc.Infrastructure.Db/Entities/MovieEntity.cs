using System.ComponentModel.DataAnnotations;
using CleanArchitecturePoc.Infrastructure.Abstractions.Entities;

namespace CleanArchitecturePoc.Infrastructure.Entities;

public class MovieEntity : BaseEntity
{
    [MaxLength(255)]
    public string Title { get; init; } = null!;
    
    public double Rating { get; init; }
    
    [MaxLength(255)]
    public string? ExternalId { get; set; }
}