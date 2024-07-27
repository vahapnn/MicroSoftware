using Microsoft.AspNetCore.Mvc;
using MicroYazilim.BusinessLogic.HizmetLogic.Interfaces;
using MicroYazilim.Models;
using System.Diagnostics;

namespace MicroYazilim.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IHizmetRepository _hizmetRepository;
        public HomeController(ILogger<HomeController> logger,IHizmetRepository   hizmetRepository)
        {
            _hizmetRepository = hizmetRepository;
            _logger = logger;
        }

        public IActionResult Index()
        {
            var hizmetler=_hizmetRepository.GetHizmetler();
            return View(hizmetler);
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
