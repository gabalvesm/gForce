using Microsoft.AspNetCore.Mvc;

namespace GerenciamentoContatos.Controllers
{
    public class ContatoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
