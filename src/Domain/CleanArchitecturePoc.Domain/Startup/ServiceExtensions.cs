using CleanArchitecturePoc.Application.Contracts.Abstractions.Services;
using CleanArchitecturePoc.Domain.Abstractions.Mappers;
using CleanArchitecturePoc.Domain.Mappers;
using CleanArchitecturePoc.Domain.Models;
using CleanArchitecturePoc.Domain.Services;
using CleanArchitecturePoc.Models.Dtos;
using Microsoft.Extensions.DependencyInjection;

namespace CleanArchitecturePoc.Domain.Startup;

public static class ServiceExtensions
{
    public static IServiceCollection AddDomainServices(this IServiceCollection services)
    {
        return services
                
                // Register domain mappers
                .AddSingleton<IMapper<Movie, MovieDto>, MovieMapper>()
                
                // Register domain services   
                .AddScoped<IGenericService<MovieDto>, MovieService>();
    }
}