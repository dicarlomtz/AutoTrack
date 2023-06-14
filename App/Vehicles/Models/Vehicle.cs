using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

using AutoTrack.App.Vehicles.Configurations;

namespace AutoTrack.App.Vehicles.Models;


[EntityTypeConfiguration(typeof(VehicleEntityTypeConfiguration))]
public class Vehicle
{
    [DatabaseGenerated(DatabaseGeneratedOption.None)]
    public string Id { get; set; } // no auto-generate
    public long OrganizationId { get; set; } // one-to-many
    [Required]
    [MaxLength(25)]
    public string Model { get; set; }
}
