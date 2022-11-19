using Microsoft.AspNetCore.Mvc;

namespace UpSchool_.NETCore.ViewComponents.Dashboard
{
    public class _FeatureDashboardPartial :ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
