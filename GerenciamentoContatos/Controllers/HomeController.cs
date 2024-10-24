using System.Diagnostics;
using GerenciamentoContatos.Models;
using Microsoft.AspNetCore.Mvc;

namespace GerenciamentoContatos.Controllers
{
    public class HomeController : Controller
    {
        

       

        public IActionResult Index()
        {
            HomeModel Home = new HomeModel();
            Home.Nome = "Gabriel Jesus";
            Home.Email = "biel.alvesmoura@gmail.com";
            return View(Home);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
