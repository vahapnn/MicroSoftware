using Microsoft.AspNetCore.Mvc;
using MicroYazilim.BusinessLogic.ReferansLogic.Interfaces;

namespace MicroYazilim.Controllers
{
    public class ReferansController : Controller
    {
        private readonly IReferansRepo referansRepo;
        public ReferansController(IReferansRepo _referansRepo)
        {
            referansRepo = _referansRepo;
        }
        public IActionResult GetReferans()
        {
            var rfr=referansRepo.GetReferanslar();
            return View(rfr);
        }
        public IActionResult Details(int id) { 
           var detay=referansRepo.ReferansDetails(id);
            return View(detay);
        }
    }
}
