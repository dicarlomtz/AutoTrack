namespace AutoTrack.App.Configuration.Startup.Services;

public class ServicesConfiguration : IConfiguration<IServiceCollection>
{
    public void Configure(IServiceCollection services)
    {
        // Add{GROUP_NAME} registers a group of services
        services.AddMiddlewareServices();
        services.AddControllers();
        services.AddEndpointsApiExplorer();
        services.AddSwaggerGen();
        services.AddServiceDependencies();
        // Add services to the container.
    }
}
