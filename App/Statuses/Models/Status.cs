using System.ComponentModel.DataAnnotations;
using AutoTrack.App.Statuses.Configurations;
using Microsoft.EntityFrameworkCore;

namespace AutoTrack.App.Statuses.Models;


[EntityTypeConfiguration(typeof(StatusEntityTypeConfiguration))]
public class Status
{
    public long Id { get; set; }
    public long WorkshopId { get; set; } // one-to-many
    [Required]
    [MaxLength(15)]
    public String Title { get; set; }
    public String Description { get; set; }
}
