using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography.X509Certificates;

namespace nevaPortfolyo.ViewComponents
{
    public class _StatisticComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
