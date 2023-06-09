using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

using AutoTrack.App.Processes.Models;

namespace AutoTrack.App.Processes.Configurations;


public class ProcessEntityTypeConfiguration : IEntityTypeConfiguration<Process>
{
    public void Configure(EntityTypeBuilder<Process> builder)
    {
        builder
            .HasMany(process => process.Steps)
            .WithMany();
    }
}
