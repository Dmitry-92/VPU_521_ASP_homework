using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Academy2.Models;

[PrimaryKey(nameof(teacher), nameof(discipline))]
public class TeachersDisciplinesRelation
{
    [Column (TypeName = "SMALLINT")]
    public int teacher { get; set; }
    [Column (TypeName = "SMALLINT")]
    public int discipline { get; set; }
}