using CleanArchitecturePoc.Domain.Abstractions.Repositories;
using CleanArchitecturePoc.Domain.Models;
using CleanArchitecturePoc.Infrastructure.Abstractions.Mappers;
using CleanArchitecturePoc.Infrastructure.Abstractions.Repositories;
using CleanArchitecturePoc.Infrastructure.Entities;
using CleanArchitecturePoc.Infrastructure.Mappers;
using CleanArchitecturePoc.Infrastructure.Repositories;
using CleanArchitecturePoc.Models.Dtos;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CleanArchitecturePoc.Infrastructure.Startup;

public static class ServiceExtensions
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
    {
        return services

            .AddDbContext<MyDbContext>((sp, options) =>
            {
                var config = sp.GetRequiredService<IConfiguration>();
                var connectionString = config.GetConnectionString("DefaultConnection");
                options.UseNpgsql(
                    connectionString,
                    npgsqlOptions =>
                    {
                        npgsqlOptions.MigrationsAssembly("CleanArchitecturePoc.Migrations");
                        // npgsqlOptions.EnableRetryOnFailure();
                    });
            })
            
            // Register mappers
            .AddSingleton<IMapper<Movie, MovieEntity>, MovieEntityMapper>()

            // Register repositories
            .AddScoped<IGenericRepository<Movie>, MovieRepository>();
    }
}