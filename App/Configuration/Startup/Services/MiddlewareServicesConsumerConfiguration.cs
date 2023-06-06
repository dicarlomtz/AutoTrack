namespace AutoTrack.App.Configuration.Startup.Services;

public class MiddlewareServicesConsumerConfiguration : IConfiguration<IApplicationBuilder>
{
    public void Configure(IApplicationBuilder app)
    {
        app.UseHttpsRedirection();
        app.UseAuthorization();
        app.UseEndpoints(config => config.MapControllers());
    }
}
