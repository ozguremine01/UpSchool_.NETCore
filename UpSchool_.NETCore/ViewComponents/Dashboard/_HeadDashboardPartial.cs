using Microsoft.AspNetCore.Mvc;

namespace UpSchool_.NETCore.ViewComponents.Dashboard
{
    public class _HeadDashboardPartial : ViewComponent
    {
        //IViewComponentResult türünde metotlarda View gelmiyor.
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
