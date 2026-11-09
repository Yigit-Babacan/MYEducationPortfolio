using Microsoft.AspNetCore.Mvc;

namespace MYPortfolio.ViewComponents.DefaultViewComponents
{
    public class _DefaultNavbarComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();

        }
    }

}
