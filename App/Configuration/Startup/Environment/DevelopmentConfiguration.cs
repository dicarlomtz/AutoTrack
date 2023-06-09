using AutoTrack.App.Shared.Contracts;

namespace AutoTrack.App.Configuration.Startup.Environment;


public class DevelopmentConfiguration : IConfiguration<IApplicationBuilder>
{
    public void Configure(IApplicationBuilder app)
    {
        throw new NotImplementedException();
    }
}
