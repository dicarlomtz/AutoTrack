using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AutoTrack.App.Vehicles.Models;


public class Vehicle
{
    [DatabaseGenerated(DatabaseGeneratedOption.None)]
    public string Id { get; set; } // no auto-generate
    public long WorkshopId { get; set; } // one-to-many
    [Required]
    [MaxLength(25)]
    public string Model { get; set; }
}
