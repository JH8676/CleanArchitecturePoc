using CleanArchitecturePoc.API.Endpoints;
using CleanArchitecturePoc.Models.Dtos;

namespace CleanArchitecturePoc.API.Startup;

public static class MinimalApiEndpointExtensions
{
    public static void RegisterEndpoints(this WebApplication app)
    {
        RegisterMovieEndpoints(app);
    }

    private static void RegisterMovieEndpoints(this WebApplication app)
    {
        var routeGroup = BuildRouteGroup(app, $"{nameof(MovieDto)}s");
        routeGroup.MapGet("/", MovieEndpoints.GetMoviesAsync);
    }
    
    private static RouteGroupBuilder BuildRouteGroup(WebApplication app, string groupName)
    {
        var routeGroup = app.MapGroup($"/api/{groupName.Replace("Dto", string.Empty).Replace(" ", "-").ToLowerInvariant()}")
            .WithTags(groupName)
            .WithOpenApi();
        
        return routeGroup;
    }
}