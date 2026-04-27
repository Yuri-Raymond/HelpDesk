namespace HelpDesk.Models;

public class UsuarioModel
{
    [Required(ErrorMessage = "O campo Id é obrigatório.")]
    public Guid Id { get; set; }

    [Required(ErrorMessage = "O campo Nome é obrigatório.")]
    public required string Nome { get; set; }
     
    public required string Email { get; set; }

    public required string Senha { get; set; }

    public List<ChamadoModel> Chamados { get; set; };
}