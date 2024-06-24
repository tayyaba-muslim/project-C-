using Microsoft.AspNetCore.Mvc;
using project.Models;

namespace project.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(Product prd)
        {
            if (ModelState.IsValid)
            {
                return Content("data is all good");
            }

                return View();
        }
    }
    
}
