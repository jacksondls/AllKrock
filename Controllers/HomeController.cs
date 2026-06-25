using System.Diagnostics;
using AllKrock.Models;
using Microsoft.AspNetCore.Mvc;

namespace AllKrock.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            List<Produto> produtos = new List<Produto>
            {
                new Produto { Id = 1, Nome = "Chiclete", Imagem = "/images/Chiclete.png" },

                new Produto { Id = 2, Nome = "Defumada", Imagem = "/images/Defumada.png"},

                new Produto { Id = 3, Nome = "Pedacinho do Céu", Imagem = "/images/pedacinhoDoCeu.png"},

                new Produto { Id = 4, Nome = "Uva", Imagem = "/images/Uva.png"},

                new Produto { Id = 5, Nome = "Ninho", Imagem = "/images/Ninho.png"}

            };
            return View(produtos);
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
