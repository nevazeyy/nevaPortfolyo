using Microsoft.AspNetCore.Mvc;

namespace nevaPortfolyo.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
