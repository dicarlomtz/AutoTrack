using AutoTrack.App.Shared.Contracts;

namespace AutoTrack.App.Configuration.Startup.Environment;


public class TestingConfiguration : IConfiguration<IApplicationBuilder>
{
    public void Configure(IApplicationBuilder app)
    {
        throw new NotImplementedException();
    }
}
