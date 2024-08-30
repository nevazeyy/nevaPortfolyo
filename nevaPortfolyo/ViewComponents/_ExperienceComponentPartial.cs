using Microsoft.AspNetCore.Mvc;
using nevaPortfolyo.DAL.Context;

namespace nevaPortfolyo.ViewComponents
{
    public class _ExperienceComponentPartial:ViewComponent
    {
        NevaPortfolioContext context = new NevaPortfolioContext();
        public IViewComponentResult Invoke()
        {
            var values = context.Experiences.ToList();
            return View(values);
        }
    }
}
