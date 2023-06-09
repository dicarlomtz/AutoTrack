using AutoTrack.App.Statuses.Models;
using AutoTrack.App.Notes.Models;
using AutoTrack.App.Steps.Models;

namespace AutoTrack.App.VehicleProcessSteps.Models;


public class VehicleProcessStep
{
    public long Id { get; set; }
    public long VehicleProcessId { get; set; } // one-to-many
    public long StepId { get; set; } // one-to-many
    public Step Step { get; set; }
    public long StatusId { get; set; } // one-to-many
    public Status Status { get; set; }
    public List<Note> Notes { get; set; } // one-to-many
}
