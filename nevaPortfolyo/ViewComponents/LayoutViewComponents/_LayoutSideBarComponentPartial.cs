using Microsoft.AspNetCore.Mvc;

namespace nevaPortfolyo.ViewComponents.LayoutViewComponents
{
	public class _LayoutSideBarComponentPartial:ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
