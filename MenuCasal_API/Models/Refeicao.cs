namespace MenuCasal_API.Models;

public class Refeicao
{
    public int Id { get; set; }
    public DayOfWeek DiaSemana { get; set; }
    public string? Descricao { get; set; }
    public DateOnly Data { get; set; }
}
