using Microsoft.AspNetCore.Mvc;

namespace Progra1BD.Controllers
{
    public class AboutController : Controller
    {
        // GET
        public IActionResult About()
        {
            return View();
        }
    }
}