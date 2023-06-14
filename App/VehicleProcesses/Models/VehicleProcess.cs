using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

using AutoTrack.App.VehicleProcesses.Configurations;
using AutoTrack.App.VehicleProcessSteps.Models;
using AutoTrack.App.Vehicles.Models;
using AutoTrack.App.Statuses.Models;
using AutoTrack.App.Notes.Models;
using AutoTrack.App.Processes.Models;

namespace AutoTrack.App.VehileProcesses.Models;

[Index(nameof(VehicleId))]
[EntityTypeConfiguration(typeof(VehicleProcessEntityTypeConfiguration))]
public class VehicleProcess
{
    public long Id { get; set; }
    public long WorkshopId { get; set; } // one-to-many
    public string VehicleId { get; set; } // one-to-many
    public Vehicle Vehicle { get; set; }
    public bool Done { get; set; }
    [Required]
    public String Description { get; set; }
    public long StatusId { get; set; } // one-to-many
    public Status Status { get; set; }
    public long ProcessId { get; set; } // one-to-many
    public Process Process { get; set; }
    public List<VehicleProcessStep> VehicleProcessSteps { get; set; } // one-to-many
    public List<Note> Notes { get; } = new(); // many-to-many
}
