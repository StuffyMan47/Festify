using System.Reflection;
using Application;
using Application.Interfaces.Settings;
using Application.Services.UserContext;
using Infrastructure.Authentication;
using Infrastructure.DAL;
using Infrastructure.Services;
using Infrastructure.Swagger;
using Infrastructure.Validation;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure;

public static class Startup
{
    public static async Task<IServiceCollection> RegisterFestifyModule(this IServiceCollection services, IConfiguration config, IWebHostEnvironment environment)
    {
        Assembly[] assemblies =
        [
            typeof(Application.Startup).Assembly,
            typeof(Startup).Assembly,
        ];
        services.AddFestifyAuth(config);
        services.AddHttpContextAccessor();
        services.AddScoped<IUserContextProvider, UserContextProvider>();
        services.AddDataAccessLayer(config, environment);
        services.AddFestifyApplicationLayer();
        services.AddSingleton<IFestifySettings, FestifySettigns>();

        services.AddValidationBuilder();

        services.RegisterServicesByInterfaces(assemblies);
        services.AddSwaggerBuilder();
        return await Task.FromResult(services);
    }
}