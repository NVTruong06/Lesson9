using Microsoft.AspNetCore.Mvc;

namespace Lesson9.Areas.Admin.ViewComponents
{
    public class NavLeftViewComponent : Controller
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
