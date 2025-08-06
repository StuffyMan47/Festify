using Application.UseCase.User.CreateUser;
using Application.UseCase.User.GenerateToken;
using Application.UseCase.User.Login;
using Application.UseCase.User.RefreshToken;
using Microsoft.Extensions.DependencyInjection;

namespace Application;

public static class Startup
{
    public static IServiceCollection AddFestifyApplicationLayer(this IServiceCollection services)
    {
        services.AddScoped<LoginUseCase>();
        services.AddScoped<CreateUserUseCase>();
        services.AddScoped<GenerateTokenUseCase>();
        services.AddScoped<RefreshTokenUseCase>();
        
        return services;
    }
}