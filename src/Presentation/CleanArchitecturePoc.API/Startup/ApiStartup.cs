using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace CleanArchitecturePoc.API.Startup;

public static class ApiStartup
{
    public static WebApplication CreateApiApplication(WebApplicationBuilder builder)
    {
        // var builder = WebApplication.CreateBuilder(args);
        //
        // additionalServices?.Invoke(builder.Services);
        
        builder.Services.AddOpenApi();
        
        // Add services to the container.
        builder.Services.AddControllers();
        builder.Services.AddEndpointsApiExplorer();
        // builder.Services.AddSwaggerGen();
        

        // Configure other services here (e.g., database, authentication, etc.)

        var app = builder.Build();

        // Configure the HTTP request pipeline.
        // if (app.Environment.IsDevelopment())
        // {
        //     app.UseSwagger();
        //     app.UseSwaggerUI();
        // }
        
        if (app.Environment.IsDevelopment())
        {
            app.MapOpenApi();
        }

        app.UseHttpsRedirection();
        app.UseAuthorization();
        
        app.MapGet("/hello", () => "Hello World!");
        app.RegisterEndpoints();

        return app;
    }
}