using Microsoft.AspNetCore.Mvc;
using MicroYazilim.BusinessLogic.HizmetLogic.Interfaces;
using MicroYazilim.Models.Data;

namespace MicroYazilim.Controllers
{
    public class HizmetController : Controller
    {
        private readonly IHizmetRepository _hizmetRepository;
        public HizmetController(IHizmetRepository hizmetRepository)
        {
            _hizmetRepository = hizmetRepository;
        }
        //Context context=new Context();
        public IActionResult Index()
        {
            //var hzm=context.Hizmetler.ToList();
            //return View(hzm);
            var hzm = _hizmetRepository.GetHizmetler();
            return View(hzm);
        }
        public IActionResult Details(int id) { 
           var detay= _hizmetRepository.HizmetDetails(id);
            return View(detay);
        }
    }
}
