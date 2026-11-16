using System.ComponentModel.DataAnnotations.Schema;

namespace Academy2.Models;

[Table("RequiredDisciplines")]
public class RequiredDiscipline
{
    [Column("discipline")]
    public int discipline { get; set; }

    [Column("required_discipline")]
    public int required_discipline { get; set; }

    [ForeignKey(nameof(discipline))]
    public Discipline Discipline { get; set; } = default!;

    [ForeignKey(nameof(required_discipline))]
    public Discipline Required { get; set; } = default!;
}