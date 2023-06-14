using System.ComponentModel.DataAnnotations;
using AutoTrack.App.Processes.Models;
using AutoTrack.App.Steps.Configurations;
using Microsoft.EntityFrameworkCore;

namespace AutoTrack.App.Steps.Models;


[EntityTypeConfiguration(typeof(StepEntityTypeConfiguration))]
public class Step
{
    public long Id { get; set; }
    public long WorkshopId { get; set; } // one-to-many
    [Required]
    [MaxLength(25)]
    public string Title { get; set; }
    [Required]
    public string Description { get; set; }
    public List<Process> Processes { get; } = new(); // many-to-many
}
