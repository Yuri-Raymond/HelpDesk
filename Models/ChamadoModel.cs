namespace HelpDesk.Models;

public class ChamadoModel
{
    public int Id { get; set; }

    public string Titulo { get; set; }
    public string Descricao { get; set; }

    public DateTime DataAbertura { get; set; } = DateTime.Now;

    public int UsuarioId { get; set; }
    public UsuarioModel Usuario { get; set; }

    public int? TecnicoId { get; set; }
    public TecnicoModel? Tecnico { get; set; }

    public CategoriaEnums Categoria { get; set; }
    public StatusChamadoEnums Status { get; set; }

    public string? Solucao { get; set; }

    public List<ComentarioModel> Comentarios { get; set; } = new();
}