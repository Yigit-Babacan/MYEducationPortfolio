using Microsoft.AspNetCore.Mvc;

namespace MYPortfolio.Areas.Admin.ViewComponents.AdminLayoutViewComponents
{
    public class _AdminLayoutStyleComponentPartial : ViewComponent
    {

        public IViewComponentResult Invoke()
        {
            return View();  
        }
    }
}
