using CleanArchitecturePoc.Application.Contracts.Abstractions.Services;
using CleanArchitecturePoc.Models.Dtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace CleanArchitecturePoc.API.Endpoints;

public static class MovieEndpoints
{
    public static async Task<Results<Ok<IEnumerable<MovieDto>>, NotFound>> GetMoviesAsync(
        [FromServices] IGenericService<MovieDto> service,
        CancellationToken cancellationToken)
        => await service.GetAllAsync(cancellationToken) is { } movies
            ? TypedResults.Ok(movies)
            : TypedResults.NotFound();
}