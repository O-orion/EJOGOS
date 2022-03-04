using EJOGOS.Models;
using Microsoft.AspNetCore.Mvc;

namespace EJOGOS.Controllers
{
    public class EquipeController1 : Controller
    {
        public IActionResult Index()
        {
            Equipe equipes = new Equipe();
            ViewBag.equipe = equipes.ListaEquipes(); //ViewBag reserva espaço para os valores vindo back serem armazenados;
            return View();
        }
    }
}
