using Microsoft.AspNetCore.Mvc;

namespace MYPortfolio.ViewComponents.DefaultViewComponents
{
    public class _DefaultStyleComponentPartial :ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
