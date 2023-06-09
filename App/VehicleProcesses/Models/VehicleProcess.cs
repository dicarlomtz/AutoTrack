using System.ComponentModel.DataAnnotations;

using AutoTrack.App.Statuses.Models;
using AutoTrack.App.Notes.Models;
using AutoTrack.App.VehicleProcessSteps.Models;
using AutoTrack.App.Vehicles.Models;

namespace AutoTrack.App.VehileProcesses.Models;


public class VehicleProcess
{
    public long Id { get; set; }
    public long WorkshopId { get; set; } // one-to-many
    public long VehicleId { get; set; } // one-to-many
    public Vehicle Vehicle { get; set; }
    [Required]
    public String Description { get; set; }
    public long StatusId { get; set; } // one-to-many
    public Status Status { get; set; }
    public List<VehicleProcessStep> VehicleProcessSteps { get; set; } // one-to-many
    public List<Note> Notes { get; set; } // one-to-many
}
