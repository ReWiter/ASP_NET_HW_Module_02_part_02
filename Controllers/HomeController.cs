using ASP_NET_HW_Module_02_part_02.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ASP_NET_HW_Module_02_part_02.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ICocktailChoosing _cocktailChoosing;
        private readonly IMerceneryChoosing _merceneryChoosing;
        private readonly IFigureIChoosing _figureIChoosing;
        private readonly IDeviceChoosing _deviceChoosing;
        public HomeController(ILogger<HomeController> logger, ICocktailChoosing cocktailChoosing, IMerceneryChoosing merceneryChoosing, IFigureIChoosing figureIChoosing, IDeviceChoosing deviceChoosing)
        {
            _logger = logger;
            _cocktailChoosing = cocktailChoosing;
            _merceneryChoosing = merceneryChoosing;
            _figureIChoosing = figureIChoosing;
            _deviceChoosing = deviceChoosing;
        }

        public IActionResult Index()
        {
            var newCocktail=_cocktailChoosing.addNewCocktail();
            return View(newCocktail);
        }

        public IActionResult Privacy()
        {
            var newMercenery=_merceneryChoosing.addNewMercenery();
            return View(newMercenery);
        }

        public IActionResult FigureI()
        {
            var newFigurei = _figureIChoosing.addNewFigureI();
            return View(newFigurei);
        }
        public IActionResult Device()
        {
            var newDevice=_deviceChoosing.addNewDevice();
            return View(newDevice);
        }
    }
}
