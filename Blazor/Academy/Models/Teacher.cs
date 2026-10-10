using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Acaemy.Models;
[Table("teacher")]
public class Teacher
{
    [Key]
    [Column("teacher_id")]
    public short TeacherId { get; set; }
    
    [Column("first_name")]
    [Required]
    public string FirstName { get; set; } = string.Empty;
    
    [Column("last_name")]
    [Required]
    public string LastName { get; set; } = string.Empty;
    
    [Column("middle_name")]
    public string? MiddleName { get; set; }
    
    [Column("birth_date")]
    public DateTime? BirthDate { get; set; }
    
    [Column("email")]
    public string? Email { get; set; }
    
    [Column("phone")]
    public string? Phone { get; set; }
    
    [Column("photo")]
    public byte[]? Photo { get; set; }
    
    [Column("rate")]
    public decimal? Rate { get; set; }
    
    [Column("work_since")]
    public DateTime? WorkSince { get; set; }
}

