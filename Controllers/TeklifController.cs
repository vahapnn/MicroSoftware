using Microsoft.AspNetCore.Mvc;
using MicroYazilim.Models;
using MicroYazilim.Models.Data;

namespace MicroYazilim.Controllers
{
    public class TeklifController : Controller
    {
        private readonly Context context=new Context(); 
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult TeklifAl() { 
          return View();
        }
        [HttpPost]
        public IActionResult TeklifAl(Teklif teklif) {
            context.Teklifs.Add(teklif);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
