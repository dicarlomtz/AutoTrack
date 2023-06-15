using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

using AutoTrack.App.VehileProcesses.Models;
using AutoTrack.App.Workshops.Models;

namespace AutoTrack.App.VehicleProcesses.Configurations;


public class VehicleProcessEntityTypeConfiguration : IEntityTypeConfiguration<VehicleProcess>
{
    public void Configure(EntityTypeBuilder<VehicleProcess> builder)
    {
        builder
            .HasMany(vehicleProcess => vehicleProcess.Notes)
            .WithMany();

        builder
            .HasOne<Workshop>()
            .WithMany()
            .HasForeignKey(vehicleProcess => vehicleProcess.WorkshopId)
            .IsRequired();

        builder
            .HasOne(vehicleProcess => vehicleProcess.Status)
            .WithMany()
            .HasForeignKey(vehicleProcess => vehicleProcess.StatusId)
            .OnDelete(DeleteBehavior.Restrict);

        builder
            .HasOne(vehicleProcess => vehicleProcess.Process)
            .WithMany()
            .HasForeignKey(vehicleProcess => vehicleProcess.ProcessId)
            .OnDelete(DeleteBehavior.Restrict);

        builder
            .HasOne(vehicleProcess => vehicleProcess.Vehicle)
            .WithMany()
            .HasForeignKey(vehicleProcess => vehicleProcess.VehicleId)
            .OnDelete(DeleteBehavior.Cascade);

        builder
           .Property(vehicleProcess => vehicleProcess.Done)
           .HasDefaultValue(false);
    }
}
