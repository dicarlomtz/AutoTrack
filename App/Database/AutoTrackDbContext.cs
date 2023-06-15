using Microsoft.EntityFrameworkCore;
using AutoTrack.App.Statuses.Models;
using AutoTrack.App.Notes.Models;
using AutoTrack.App.Database.Environment;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using AutoTrack.App.Organizations.Models;
using AutoTrack.App.Workshops.Models;
using AutoTrack.App.Steps.Models;
using AutoTrack.App.VehileProcesses.Models;
using AutoTrack.App.VehicleProcessSteps.Models;
using AutoTrack.App.Vehicles.Models;
using AutoTrack.App.Processes.Models;

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

    protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
    {
        configurationBuilder.Conventions.Remove(typeof(ForeignKeyIndexConvention));
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        OnConfiguringEnvironment(optionsBuilder);
    }

    private void OnConfiguringEnvironment(DbContextOptionsBuilder optionsBuilder)
    {
        if (_hostEnvironment.IsLocal())
        {
            optionsBuilder.ConfigureLocalDb();
            return;
        }

        if (_hostEnvironment.IsDevelopment())
        {
            optionsBuilder.ConfigureDevelopmentDb();
            return;
        }

        if (_hostEnvironment.IsStaging())
        {
            optionsBuilder.ConfigureStagingDb();
            return;
        }

        if (_hostEnvironment.IsTesting())
        {
            optionsBuilder.ConfigureStagingDb();
            return;
        }

        optionsBuilder.ConfigureProductionDb();
        return;
    }
}
