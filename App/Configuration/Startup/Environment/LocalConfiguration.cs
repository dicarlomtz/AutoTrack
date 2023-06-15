namespace AutoTrack.App.Configuration.Startup.Environment;


public static class LocalConfiguration
{
    public static void ConfigureLocal(this IApplicationBuilder app)
    {
        app.UseSwagger();
        app.UseSwaggerUI();
    }
}
