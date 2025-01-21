using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MenuCasal_API.Models;

[Table("Refeicoes")]
public class Refeicao
{
    [Key]
    [Column("Id")]
    public int Id { get; set; }

    [Column("DiaSemana")]
    public DayOfWeek DiaSemana { get; set; }

    [Column("Descricao")]
    public string? Descricao { get; set; }

    [Column("Data")]
    public DateOnly Data { get; set; }
}
