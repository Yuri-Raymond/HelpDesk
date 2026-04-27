namespace HelpDesk.Models;

public class TecnicoModel : UsuarioModel
{
    public string Especialidade { get; set; }

    public List<ChamadoModel> ChamadosAtendidos { get; set; } = new();
}