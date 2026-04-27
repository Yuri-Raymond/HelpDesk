namespace HelpDesk.Models;

public class ComentarioModel
{
    public int Id { get; set; }

    public string Mensagem { get; set; }
    public DateTime Data { get; set; } = DateTime.Now;

    // FK para Chamado
    public int ChamadoId { get; set; }
    public ChamadoModel Chamado { get; set; }

    // FK para Usuário (autor do comentário)
    public int UsuarioId { get; set; }
    public UsuarioModel Usuario { get; set; }
}