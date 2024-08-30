using Microsoft.AspNetCore.Mvc;

namespace nevaPortfolyo.ViewComponents
{
    public class _PortfolioComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();                            
        }
    }
}
