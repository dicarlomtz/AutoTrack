using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

using AutoTrack.App.Workshops.Models;
using AutoTrack.App.Steps.Models;

namespace AutoTrack.App.Steps.Configurations;


public class StepEntityTypeConfiguration : IEntityTypeConfiguration<Step>
{
    public void Configure(EntityTypeBuilder<Step> builder)
    {
        builder
            .HasOne<Workshop>()
            .WithMany()
            .HasForeignKey(step => step.WorkshopId)
            .IsRequired();
    }
}
