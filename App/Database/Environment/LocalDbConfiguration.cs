using Microsoft.EntityFrameworkCore;

using AutoTrack.App.Shared.Contracts;

namespace AutoTrack.App.Database.Environment;


public class LocalDbConfiguration : IConfiguration<DbContextOptionsBuilder>
{
    public void Configure(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder
            .EnableSensitiveDataLogging()
            .UseSqlServer("name=ConnectionStrings:AutoTrackLocalDbConnection");
    }
}
