using CleanArchitecturePoc.Domain.Abstractions.Providers;
using Microsoft.Extensions.DependencyInjection;

namespace CleanArchitecturePoc.Infrastructure.IMDb.Startup;

public static class ServiceExtensions
{
    public static IServiceCollection AddImdbServices(this IServiceCollection services)
    {
        return services

            .AddScoped<IMovieProvider, ImdbMovieProvider>();
    }
}