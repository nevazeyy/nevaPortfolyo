using Microsoft.AspNetCore.Mvc;

namespace nevaPortfolyo.ViewComponents
{
    public class _ContactComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
