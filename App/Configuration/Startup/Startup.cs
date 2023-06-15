using AutoTrack.App.Configuration.Startup.Environment;
using AutoTrack.App.Configuration.Startup.Services;

namespace AutoTrack.App.Configuration.Startup;


public class Startup
{
    public IConfiguration Configuration { get; }

    public Startup(IConfiguration configuration)
    {
        Configuration = configuration;
    }

    public void ConfigureServices(IServiceCollection services)
    {
        services.AddServicesConfiguration();
    }

    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
        ConfigureEnvironment(app, env);
        app.UseServices();
    }

    private void ConfigureEnvironment(IApplicationBuilder app, IWebHostEnvironment env)
    {
        if (env.IsLocal())
        {
            app.ConfigureLocal();
            return;
        }

        if (env.IsDevelopment())
        {
            app.ConfigureDevelopment();
            return;
        }

        if (env.IsStaging())
        {
            app.ConfigureProduction();
            return;
        }

        if (env.IsTesting())
        {
            app.ConfigureTesting();
            return;
        }

        app.ConfigureProduction();
        return;
    }
}
