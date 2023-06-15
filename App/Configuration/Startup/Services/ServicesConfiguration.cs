using System.Text.Json.Serialization;
using AutoTrack.App.Database;

namespace AutoTrack.App.Configuration.Startup.Services;


public static class ServicesConfiguration
{
    public static void AddServicesConfiguration(this IServiceCollection services)
    {
        // Add{GROUP_NAME} registers a group of services
        // Add services to the container.
        services.AddAppMiddlewares();
        services.AddControllers()
            .AddJsonOptions(options =>
            {
                options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles;
            });
        services.AddEndpointsApiExplorer();
        services.AddSwaggerGen();
        services.AddAppDependencies();

        services.AddDbContext<AutoTrackDbContext>();
    }
}
