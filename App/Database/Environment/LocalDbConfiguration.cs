using Microsoft.EntityFrameworkCore;

namespace AutoTrack.App.Database.Environment;


public static class LocalDbConfiguration
{
    public static void ConfigureLocalDb(this DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder
            .EnableSensitiveDataLogging()
            .UseSqlServer("name=ConnectionStrings:AutoTrackLocalDbConnection");
    }
}
