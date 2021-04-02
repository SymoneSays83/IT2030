using Microsoft.AspNetCore.Mvc;
using Project_2.Models;

namespace Project_2.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.DA = 0;
            ViewBag.T = 0;
            return View();
        }

        [HttpPost]
        public IActionResult Index(CalculateModel model)
        {
            if(ModelState.IsValid) {
                decimal? discount = model.DiscountAmount();
                ViewBag.DA = discount;
                ViewBag.T = model.Subtotal - discount;
            }
            else
            {
                ViewBag.DA = 0;
                ViewBag.T = 0;
            }
            return View(model);
        }
    }
}
