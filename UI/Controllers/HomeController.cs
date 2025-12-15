using System.Diagnostics;
using Domain.DTOs;
using Domain.Entities;
using Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;
using UI.Models;

namespace UI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private IPlantsUseCase useCase;


        public HomeController(ILogger<HomeController> logger, IPlantsUseCase usecase)
        {
            _logger = logger;
            this.useCase = usecase;
        }

        public IActionResult Index()
        {
            IndexDTO lists = useCase.GetHomeIndexData(null);
            return View(lists);
        }

        [HttpPost]
        public IActionResult Index(int categoriaID)
        {
            IndexDTO lists = useCase.GetHomeIndexData(categoriaID);
            lists.SelectedCategoryId = categoriaID; 
            return View(lists);
        }

        public IActionResult ChangePrice(int id)
        {
            
            PlantDetailDTO details = useCase.GetPlantDetailUseCase(id);
            return View(details);
        }
        [HttpPost]
        public IActionResult ChangePrice(int plantId, string newPrice)
        {
            newPrice= newPrice.Replace(".", ",");
            decimal formattedPrice= decimal.Parse(newPrice);
            Boolean correcto=useCase.UpdatePlantPriceUseCase(plantId, formattedPrice);
            PlantDetailDTO details = useCase.GetPlantDetailUseCase(plantId);

            ViewBag.correcto = correcto;
            return View(details);
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
