using Microsoft.AspNetCore.Mvc;

namespace Lesson9.Areas.Admin.ViewComponents
{
    public class NavBarViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View("~/Areas/Admin/Views/Shared/Components/NavBar/Default.cshtml");
        }
    }
}
