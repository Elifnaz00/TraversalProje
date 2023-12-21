using Microsoft.AspNetCore.Mvc;

namespace TraversalProje.ViewComponents.MemberDashboard
{
    public class _MemberLayoutLanguage:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
