using AutoTrack.App.Database;
using AutoTrack.App.Shared.Contracts;

namespace AutoTrack.App.Configuration.Startup.Services;


public class ServicesConfiguration : IConfiguration<IServiceCollection>
{
    public void Configure(IServiceCollection services)
    {
        // Add{GROUP_NAME} registers a group of services
        // Add services to the container.
        services.AddMiddlewareServices();
        services.AddControllers();
        services.AddEndpointsApiExplorer();
        services.AddSwaggerGen();
        services.AddServiceDependencies();

        services.AddDbContext<AutoTrackDbContext>();
    }
}
