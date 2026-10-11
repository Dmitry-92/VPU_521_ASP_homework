using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Academy2.Models;

public class Direction
{
    public byte directionId { get; set; }
    public string direction_name { get; set; } 
}