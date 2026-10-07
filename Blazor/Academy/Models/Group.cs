using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Academy.Models;

[Table("Groups")]
public class Group
{
    [Key]
    [Column("group_id")]
    public int GroupId { get; set; }

    [Column("group_name")]
    [Required]
    public string GroupName { get; set; } = string.Empty;

    [Column("direction")]
    public byte Direction { get; set; }

    [Column("start_time")]
    public TimeSpan? StartTime { get; set; }

    [Column("weekdays")]
    public byte Weekdays { get; set; }
}