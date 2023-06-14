using AutoTrack.App.Processes.Models;
using AutoTrack.App.Steps.Models;

namespace AutoTrack.App.ProcessSteps.Models;

public class ProcessStep
{
    public long Id { get; set; }
    public long ProcessId { get; set; }
    public Process Process { get; set; } = null!;
    public long StepId { get; set; }

    public Step Step { get; set; } = null!;
}
