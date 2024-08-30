using Microsoft.AspNetCore.Mvc;
using nevaPortfolyo.DAL.Context;

namespace nevaPortfolyo.ViewComponents
{
    public class _FeatureComponentPartial : ViewComponent
    {
        NevaPortfolioContext portfolioContext = new NevaPortfolioContext();
        public IViewComponentResult Invoke()
        {
            var values = portfolioContext.Features.ToList();
            return View(values);  
        }
    }
}
