using Microsoft.AspNetCore.Mvc;
using nevaPortfolyo.DAL.Context;

namespace nevaPortfolyo.Controllers
{
    public class ExperienceController : Controller
    {
        NevaPortfolioContext context = new NevaPortfolioContext();  
        public IActionResult ExperienceList()
        {
            var values = context.Experiences.ToList();
            return View(values);
        }
    }
}
