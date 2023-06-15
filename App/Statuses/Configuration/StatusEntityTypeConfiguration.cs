using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

using AutoTrack.App.Statuses.Models;
using AutoTrack.App.Workshops.Models;

namespace AutoTrack.App.Statuses.Configurations;


public class StatusEntityTypeConfiguration : IEntityTypeConfiguration<Status>
{
    public void Configure(EntityTypeBuilder<Status> builder)
    {
        builder
            .HasOne<Workshop>()
            .WithMany()
            .HasForeignKey(status => status.WorkshopId)
            .IsRequired();
    }
}
