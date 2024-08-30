using Microsoft.AspNetCore.Mvc;
using nevaPortfolyo.DAL.Context;

namespace nevaPortfolyo.ViewComponents
{
    public class _SkillComponentPartial:ViewComponent
    {
        NevaPortfolioContext context = new NevaPortfolioContext(); 
        public IViewComponentResult Invoke()
        {
            var values = context.Skills.ToList();
            return View(values);  
        }
    }
}
