using Microsoft.AspNetCore.Mvc;
using MicroYazilim.Models;
using MicroYazilim.Models.Data;

namespace MicroYazilim.Controllers
{
    public class IletisimController : Controller
    {
        private readonly Context context=new Context();
        public IActionResult Index() {
            return View();
        }
        [HttpGet]
        public IActionResult IletisimBilgileri()
        {
            return View();
        }
        [HttpPost]
        public IActionResult IletisimBilgileri(Iletisim ıletisim)
        {
            context.Iletisim.Add(ıletisim);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
