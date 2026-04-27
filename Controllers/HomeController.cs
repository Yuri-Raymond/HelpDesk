using HelpDesk.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

public class HomeController : Controller
{
    private static List<ChamadoModel> chamados = new List<ChamadoModel>
    {
        new ChamadoModel
        {
            Id = 111,
            Titulo = "Computador não liga",
            Descricao = "PC não inicia",
            Status = StatusChamadoEnums.Aberto,
            Usuario = new UsuarioModel
            {
                Id = 1,
                Nome = "João",
                Email = "joao@email.com",
                Senha = "123"
            }
        }
    };

    public IActionResult Index()
    {
        return View(chamados);
    }
    [Route("/Home  s/{id}")]
    public IActionResult Detalhes(int id)
    {
        var chamado = chamados.FirstOrDefault(c => c.Id == id);

        if (chamado == null)
        {
            return NotFound();
        }

        return View(chamado);
    }
}