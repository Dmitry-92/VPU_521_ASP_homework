using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Academy2.Models;

[Table("Directions")]
public class Direction
{
    [Column("direction_id")]
    public byte DirectionId { get; set; }

    [Column("direction_name")]
    public string DirectionName { get; set; } = string.Empty;
}