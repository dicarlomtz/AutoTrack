namespace AutoTrack.App.Configuration.Startup.Services;


public static class ServicesConsumer
{
    public static void UseServices(this IApplicationBuilder app)
    {
        app.UseHttpsRedirection();
        app.UseAuthorization();
        app.UseEndpoints(config => config.MapControllers());
    }
}
