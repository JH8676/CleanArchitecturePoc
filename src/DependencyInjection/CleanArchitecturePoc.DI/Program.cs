// See https://aka.ms/new-console-template for more information

using CleanArchitecturePoc.API.Startup;
using CleanArchitecturePoc.Domain.Startup;
using CleanArchitecturePoc.Infrastructure.IMDb.Startup;
using CleanArchitecturePoc.Infrastructure.Startup;
using Microsoft.AspNetCore.Builder;

var builder = WebApplication.CreateBuilder(args);

builder.Services
    .AddInfrastructure(builder.Configuration)
    .AddImdbServices()
    .AddDomainServices();

var app = ApiStartup.CreateApiApplication(builder);

await app.RunAsync();