using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

using AutoTrack.App.VehicleProcessSteps.Models;

namespace AutoTrack.App.VehicleProcessSteps.Configurations;

public class VehicleProcessStepEntityTypeConfiguration : IEntityTypeConfiguration<VehicleProcessStep>
{
    public void Configure(EntityTypeBuilder<VehicleProcessStep> builder)
    {
        builder
            .HasMany(vehicleProcessStep => vehicleProcessStep.Notes)
            .WithMany();

        builder
            .HasOne(vehicleProcessStep => vehicleProcessStep.Status)
            .WithMany()
            .OnDelete(DeleteBehavior.Restrict);

        builder
            .HasOne(vehicleProcessStep => vehicleProcessStep.Step)
            .WithMany()
            .OnDelete(DeleteBehavior.Restrict);

        builder
            .Property(vehicleProcessStep => vehicleProcessStep.Done)
            .HasDefaultValue(false);
    }
}
