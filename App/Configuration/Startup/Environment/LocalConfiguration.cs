using AutoTrack.App.Shared.Contracts;

namespace AutoTrack.App.Configuration.Startup.Environment;


public class LocalConfiguration : IConfiguration<IApplicationBuilder>
{
    public void Configure(IApplicationBuilder app)
    {
        app.UseSwagger();
        app.UseSwaggerUI();
    }
}
