using System.ComponentModel.DataAnnotations;

using AutoTrack.App.Workshops.Models;

namespace AutoTrack.App.Organizations.Models;


public class Organization
{
    public long Id { get; set; }
    [Required]
    public String Name { get; set; }
    [Required]
    [MaxLength(15)]
    public String Subdomain { get; set; }
    [Required]
    public String Description { get; set; }
    public String Address { get; set; }
    public List<Workshop> Workshops { get; set; } // one-to-many
}
