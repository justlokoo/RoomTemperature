using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SchoolRoomTemperature.Entities;

/// <summary>
/// Defines classroom
/// </summary>
public class Classroom
{
    [Key] public int Id { get; set; }
    public string RoomNumber { get; set; }
    public float Celsius { get; set; }
    public DateTime DateTime { get; set; }
    [NotMapped] public float Fahrenheit => 32 + Celsius / 0.5556f;
}