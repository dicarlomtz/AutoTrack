using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

using AutoTrack.App.Processes.Configurations;
using AutoTrack.App.Steps.Models;

namespace AutoTrack.App.Processes.Models;


[EntityTypeConfiguration(typeof(ProcessEntityTypeConfiguration))]
public class Process
{
    public long Id { get; set; }
    public long WorkshopId { get; set; } // one-to-many
    [Required]
    [MaxLength(25)]
    public string Title { get; set; }
    [Required]
    public string Description { get; set; }
    public List<Step> Steps { get; } = new(); // many-to-many
}
