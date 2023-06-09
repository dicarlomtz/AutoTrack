using System.ComponentModel.DataAnnotations;

namespace AutoTrack.App.Steps.Models;


public class Step
{
    public long Id { get; set; }
    public long WorkshopId { get; set; } // one-to-many
    [Required]
    [MaxLength(25)]
    public string Title { get; set; }
    [Required]
    public string Description { get; set; }
}
