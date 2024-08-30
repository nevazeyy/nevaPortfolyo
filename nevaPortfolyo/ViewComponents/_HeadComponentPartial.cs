using Microsoft.AspNetCore.Mvc;

namespace nevaPortfolyo.ViewComponents
{
    public class _HeadComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
