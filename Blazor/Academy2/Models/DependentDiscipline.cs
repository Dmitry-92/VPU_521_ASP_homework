using System.ComponentModel.DataAnnotations.Schema;

namespace Academy2.Models;

[Table("DependentDisciplines")]
public class DependentDiscipline
{
    [Column("discipline")]
    public int discipline { get; set; }

    [Column("dependent_discipline")]
    public int dependent_discipline { get; set; }

    // Навигационные свойства (необязательно, но удобно)
    [ForeignKey(nameof(discipline))]
    public Discipline Discipline { get; set; } = default!;

    [ForeignKey(nameof(dependent_discipline))]
    public Discipline Dependent { get; set; } = default!;
}