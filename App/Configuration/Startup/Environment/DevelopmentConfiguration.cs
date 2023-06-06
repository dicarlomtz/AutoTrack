namespace AutoTrack.App.Configuration.Startup.Environment;

public class DevelopmentConfiguration : IConfiguration<IApplicationBuilder>
{
    public void Configure(IApplicationBuilder app)
    {
        app.UseSwagger();
        app.UseSwaggerUI();
    }
}
