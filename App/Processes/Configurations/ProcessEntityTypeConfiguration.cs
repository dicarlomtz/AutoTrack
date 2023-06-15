using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

using AutoTrack.App.ProcessSteps.Models;
using AutoTrack.App.Processes.Models;
using AutoTrack.App.Workshops.Models;

namespace AutoTrack.App.Processes.Configurations;


public class ProcessEntityTypeConfiguration : IEntityTypeConfiguration<Process>
{
    public void Configure(EntityTypeBuilder<Process> builder)
    {
        builder
            .HasMany(process => process.Steps)
            .WithMany(step => step.Processes)
            .UsingEntity<ProcessStep>(
                left => left
                        .HasOne(processStep => processStep.Step)
                        .WithMany()
                        .HasForeignKey(process => process.StepId)
                        .OnDelete(DeleteBehavior.Restrict),
                right => right
                        .HasOne(processStep => processStep.Process)
                        .WithMany()
                        .HasForeignKey(step => step.ProcessId)
                        .OnDelete(DeleteBehavior.Restrict)
            );

        builder
            .HasOne<Workshop>()
            .WithMany()
            .HasForeignKey(process => process.WorkshopId)
            .IsRequired();
    }
}
