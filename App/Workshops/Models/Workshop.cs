using System.ComponentModel.DataAnnotations;

namespace AutoTrack.App.Workshops.Models;


public class Workshop
{
    public long Id { get; set; }
    public long OrganizationId { get; set; } // one-to-many
    [Required]
    [MaxLength(100)]
    public string Name { get; set; }
    public string Description { get; set; }
    [Required]
    [MaxLength(100)]
    public string Address { get; set; }
}
