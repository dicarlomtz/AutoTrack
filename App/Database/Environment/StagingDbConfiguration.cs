using Microsoft.EntityFrameworkCore;

using AutoTrack.App.Shared.Contracts;

namespace AutoTrack.App.Database.Environment;


public class StagingDbConfiguration : IConfiguration<DbContextOptionsBuilder>
{
    public void Configure(DbContextOptionsBuilder optionsBuilder)
    {
        throw new NotImplementedException();
    }
}
