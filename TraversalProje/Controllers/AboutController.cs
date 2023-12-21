using Microsoft.AspNetCore.Mvc;

namespace TraversalProje.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
