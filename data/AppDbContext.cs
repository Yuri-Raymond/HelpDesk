using Microsoft.EntityFrameworkCore;
using HelpDesk.Models;

public class AppDbContext : DbContext
{
    public DbSet<UsuarioModel> Usuarios { get; set; }
    public DbSet<TecnicoModel> Tecnicos { get; set; }
    public DbSet<ChamadoModel> Chamados { get; set; }
    public enum Categoria
        {
            Hardware,
            Software,
            Rede
        }

     public enum StatusChamado
        {
            Aberto,
            EmAndamento,
            Finalizado
        }

    public DbSet<ComentarioModel> Comentarios { get; set; }

    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }
}