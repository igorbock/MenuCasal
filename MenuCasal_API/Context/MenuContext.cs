namespace MenuCasal_API.Context;

public class MenuContext : DbContext
{
    public MenuContext(DbContextOptions<MenuContext> options) : base(options) { }

    public DbSet<Refeicao> Refeicoes { get; set; }
}