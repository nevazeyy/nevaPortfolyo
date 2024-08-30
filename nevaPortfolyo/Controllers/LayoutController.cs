using Microsoft.AspNetCore.Mvc;

namespace nevaPortfolyo.Controllers
{
    public class LayoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
