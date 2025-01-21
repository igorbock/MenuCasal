namespace MenuCasal_API.Controllers;

[ApiController]
[Route("[controller]")]
public class RefeicaoController
{
    [HttpGet]
    public IEnumerable<Refeicao> Get()
    {
        return new List<Refeicao>
        {
            new Refeicao { Id = 1, DiaSemana = DayOfWeek.Monday, Descricao = "Arroz, Feijão e Frango", Data = new DateOnly(2024, 1, 15) },
            new Refeicao { Id = 2, DiaSemana = DayOfWeek.Tuesday, Descricao = "Macarrão à Bolonhesa", Data = new DateOnly(2024, 1, 16) },
            new Refeicao { Id = 3, DiaSemana = DayOfWeek.Wednesday, Descricao = "Sopa de Legumes", Data = new DateOnly(2024, 1, 17) },
            new Refeicao { Id = 4, DiaSemana = DayOfWeek.Thursday, Descricao = "Peixe Grelhado com Salada", Data = new DateOnly(2024, 1, 18) },
            new Refeicao { Id = 5, DiaSemana = DayOfWeek.Friday, Descricao = "Feijoada", Data = new DateOnly(2024, 1, 19) },
            new Refeicao { Id = 6, DiaSemana = DayOfWeek.Saturday, Descricao = "Lasanha de Carne", Data = new DateOnly(2024, 1, 20) },
            new Refeicao { Id = 7, DiaSemana = DayOfWeek.Sunday, Descricao = "Churrasco", Data = new DateOnly(2024, 1, 21) },
            new Refeicao { Id = 8, DiaSemana = DayOfWeek.Monday, Descricao = "Risoto de Camarão", Data = new DateOnly(2024, 1, 22) },
            new Refeicao { Id = 9, DiaSemana = DayOfWeek.Tuesday, Descricao = "Hambúrguer Artesanal", Data = new DateOnly(2024, 1, 23) },
            new Refeicao { Id = 10, DiaSemana = DayOfWeek.Wednesday, Descricao = "Yakissoba", Data = new DateOnly(2024, 1, 24) }
        };

    }
}
