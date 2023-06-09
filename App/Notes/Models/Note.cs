using System.ComponentModel.DataAnnotations;

namespace AutoTrack.App.Notes.Models;


public class Note
{
    public long Id { get; set; }
    [Required]
    [MaxLength(25)]
    public String Title { get; set; }
    public String Description { get; set; }
}
