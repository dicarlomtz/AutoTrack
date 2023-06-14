using AutoTrack.App.Statuses.Models;
using AutoTrack.App.Notes.Models;
using AutoTrack.App.Steps.Models;
using Microsoft.EntityFrameworkCore;
using AutoTrack.App.VehicleProcessSteps.Configurations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AutoTrack.App.VehicleProcessSteps.Models;


[EntityTypeConfiguration(typeof(VehicleProcessStepEntityTypeConfiguration))]
public class VehicleProcessStep
{
    public long Id { get; set; }
    public long VehicleProcessId { get; set; } // one-to-many
    public bool Done { get; set; }
    public long StepId { get; set; } // one-to-many
    [ForeignKey(nameof(StepId))]
    public Step Step { get; set; }
    public long StatusId { get; set; } // one-to-many
    [ForeignKey(nameof(StatusId))]
    public Status Status { get; set; }
    public List<Note> Notes { get; } = new(); // many-to-many
}
