using Microsoft.AspNetCore.Mvc;
using Primeiro_Projeto_MVC.Models;
using System.Diagnostics;

namespace Primeiro_Projeto_MVC.Controllers
{
    public class HomeController : Controller
    {
       

        public IActionResult Index()
        {
            HomeModels home = new HomeModels();
            home.Nome = "Geórgia";
            home.Email = "GeorgiaSD@hotmail.com";

            return View(home);
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