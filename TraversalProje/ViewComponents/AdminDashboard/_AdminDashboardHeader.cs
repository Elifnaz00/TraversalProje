using BusinessLayer.Concrate;
using Microsoft.AspNetCore.Mvc;

namespace TraversalProje.ViewComponents.AdminDashboard
{
    public class _AdminDashboardHeader:ViewComponent
    {
        public IViewComponentResult Invoke()

        {
            return View();
        }
    }
}
