using Microsoft.EntityFrameworkCore;

using AutoTrack.App.VehicleProcessSteps.Models;
using AutoTrack.App.VehileProcesses.Models;
using AutoTrack.App.Organizations.Models;
using AutoTrack.App.Workshops.Models;
using AutoTrack.App.Processes.Models;
using AutoTrack.App.Vehicles.Models;
using AutoTrack.App.Statuses.Models;
using AutoTrack.App.Notes.Models;
using AutoTrack.App.Steps.Models;
using AutoTrack.App.Database.Environment;

namespace AutoTrack.App.Database;


public class AutoTrackDbContext : DbContext
{
    public DbSet<VehicleProcessStep> VehicleProcessSteps { get; set; }
    public DbSet<VehicleProcess> VehicleProcesses { get; set; }
    public DbSet<Organization> Organizations { get; set; }
    public DbSet<Workshop> Workshops { get; set; }
    public DbSet<Process> Processes { get; set; }
    public DbSet<Vehicle> Vehicles { get; set; }
    public DbSet<Status> Statuses { get; set; }
    public DbSet<Note> Notes { get; set; }
    public DbSet<Step> Steps { get; set; }

    public IHostEnvironment _hostEnvironment;

    public AutoTrackDbContext(DbContextOptions<AutoTrackDbContext> options, IHostEnvironment hostEnvironment)
        : base(options)
    {
        _hostEnvironment = hostEnvironment;
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        OnConfiguringEnvironment(optionsBuilder);
    }

    private void OnConfiguringEnvironment(DbContextOptionsBuilder optionsBuilder)
    {
        if (_hostEnvironment.IsLocal())
        {
            LocalDbConfiguration localDbConfiguration = new LocalDbConfiguration();
            localDbConfiguration.Configure(optionsBuilder);
            return;
        }

        if (_hostEnvironment.IsDevelopment())
        {
            DevelopmentDbConfiguration developmentDbConfiguration = new DevelopmentDbConfiguration();
            developmentDbConfiguration.Configure(optionsBuilder);
            return;
        }

        if (_hostEnvironment.IsStaging())
        {
            StagingDbConfiguration stagingDbConfiguration = new StagingDbConfiguration();
            stagingDbConfiguration.Configure(optionsBuilder);
            return;
        }

        if (_hostEnvironment.IsTesting())
        {
            TestingDbConfiguration testingDbConfiguration = new TestingDbConfiguration();
            testingDbConfiguration.Configure(optionsBuilder);
            return;
        }

        ProductionDbConfiguration productionDbConfiguration = new ProductionDbConfiguration();
        productionDbConfiguration.Configure(optionsBuilder);
    }
}
