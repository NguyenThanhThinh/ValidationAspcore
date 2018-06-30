using Microsoft.AspNetCore.Mvc;

namespace ValidationAspNetCore.Controllers
{
    using ValidationAspNetCore.Models;
    public class DemoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Validate(Employee employee)
        {
            if (ModelState.IsValid)
            {
                ModelState.AddModelError("", "PASS");
            }

            return View(nameof(Index));
        }
    }
}