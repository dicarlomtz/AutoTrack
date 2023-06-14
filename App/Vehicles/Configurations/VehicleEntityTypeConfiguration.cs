using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

using AutoTrack.App.Vehicles.Models;
using AutoTrack.App.Organizations.Models;

namespace AutoTrack.App.Vehicles.Configurations;

public class VehicleEntityTypeConfiguration : IEntityTypeConfiguration<Vehicle>
{
    public void Configure(EntityTypeBuilder<Vehicle> builder)
    {
        builder
            .HasOne<Organization>()
            .WithMany()
            .HasForeignKey(vehicle => vehicle.OrganizationId)
            .IsRequired();
    }
}
