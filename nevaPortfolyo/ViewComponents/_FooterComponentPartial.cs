using Microsoft.AspNetCore.Mvc;

namespace nevaPortfolyo.ViewComponents
{
    public class _FooterComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();  
        }
    }
}
