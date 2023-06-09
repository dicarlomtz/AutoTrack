using AutoTrack.App.Configuration.Startup.Environment;
using AutoTrack.App.Configuration.Startup.Services;

namespace AutoTrack.App.Configuration.Startup;


public class Startup
{
    public IConfiguration Configuration { get; }
    private ServicesConfiguration _servicesConfiguration { get; set; }
    private MiddlewareServicesConsumerConfiguration _middlewareServicesConsumerConfiguration { get; set; }

    public Startup(IConfiguration configuration)
    {
        Configuration = configuration;
        _servicesConfiguration = new ServicesConfiguration();
        _middlewareServicesConsumerConfiguration = new MiddlewareServicesConsumerConfiguration();
    }

    public void ConfigureServices(IServiceCollection services)
    {
        _servicesConfiguration.Configure(services);
    }

    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
        ConfigureEnvironment(app, env);
        _middlewareServicesConsumerConfiguration.Configure(app);
    }

    private void ConfigureEnvironment(IApplicationBuilder app, IWebHostEnvironment env)
    {
        if (env.IsLocal())
        {
            LocalConfiguration localConfiguration = new LocalConfiguration();
            localConfiguration.Configure(app);
            return;
        }

        if (env.IsDevelopment())
        {
            DevelopmentConfiguration developmentConfiguration = new DevelopmentConfiguration();
            developmentConfiguration.Configure(app);
            return;
        }

        if (env.IsStaging())
        {
            StagingConfiguration stagingConfiguration = new StagingConfiguration();
            stagingConfiguration.Configure(app);
            return;
        }

        if (env.IsTesting())
        {
            TestingConfiguration testingConfiguration = new TestingConfiguration();
            testingConfiguration.Configure(app);
            return;
        }

        ProductionConfiguration productionConfiguration = new ProductionConfiguration();
        productionConfiguration.Configure(app);
    }
}
