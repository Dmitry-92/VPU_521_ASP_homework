using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Academy.Models;

[Table("Directions")]

public class Direction
{
    [Key]
    [Column("direction_id")]
    public byte DirectionId { get; set; }
    
    [Column("direction_name")]
    [Required]
    public string DirectionName { get; set; } =  string.Empty;
}