using Microsoft.AspNetCore.Mvc;
using nevaPortfolyo.DAL.Context;

namespace nevaPortfolyo.ViewComponents
{
    public class _AboutComponentPartial: ViewComponent
    {
        NevaPortfolioContext portfolioContext = new NevaPortfolioContext();
        public IViewComponentResult Invoke()
        {
            ViewBag.aboutTitle = portfolioContext.Abouts.Select(x => x.Title).FirstOrDefault();
            ViewBag.aboutSubDescription=portfolioContext.Abouts.Select(x=>x.SubDescription).FirstOrDefault();
            ViewBag.aboutDetail = portfolioContext.Abouts.Select(x=>x.Details).FirstOrDefault(); 
            return View();  
        }
    }
}
