using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;
using Infrastructure;
using Infrastructure.DAL.DBContext;
using Infrastructure.Monitoring.Logging;
using Infrastructure.Swagger;
using Serilog;

StaticLogger.EnsureInitialized();
Log.Information("Application start...");

try
{
    var builder = WebApplication.CreateBuilder(args);

    builder.Services
        .AddControllers(options => options.SuppressImplicitRequiredAttributeForNonNullableReferenceTypes = true)
        .AddJsonOptions(options => options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles);

    // builder.Services.AddDbContext<AppDbContext>(
    //     options =>
    //     {
    //         options.UseNpgsql(builder.Configuration.GetConnectionString("DBConnectionString"));
    //     });

    await builder.Services.RegisterFestifyModule(builder.Configuration, builder.Environment);

    
    builder.Services.AddEndpointsApiExplorer();
    builder.Services.AddSwaggerGen();

    var app = builder.Build();

    app.UseSwaggerBuilder(builder.Environment);

// Configure the HTTP request pipeline.
    if (app.Environment.IsDevelopment())
    {
        app.UseSwagger();
        app.UseSwaggerUI();
    }

    using var scope = app.Services.CreateScope();
    await using var dbContext = scope.ServiceProvider.GetRequiredService<AppDbContext>();
    await dbContext.Database.EnsureCreatedAsync();

    app.UseHttpsRedirection();

    app.UseAuthorization();


    app.MapControllers();

    await app.RunAsync();
}
catch (Exception ex) when (!ex.GetType().Name.Equals("HostAbortedException", StringComparison.Ordinal))
{
    StaticLogger.EnsureInitialized();
    Log.Fatal(ex, "Приложение не может быть запущено из-за критической ошибки");
}
finally
{
    StaticLogger.EnsureInitialized();
    Log.Information("Application shutdown...");
    await Log.CloseAndFlushAsync();
}

namespace Festify
{
    [SuppressMessage("Minor Code Smell", "S2094:Classes should not be empty")]
    public class Program;
}