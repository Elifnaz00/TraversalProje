using Microsoft.AspNetCore.Mvc;

namespace TraversalProje.ViewComponents.MemberDashboard
{
    public class _MemberLayoutHeaderContent:ViewComponent
    {
        public IViewComponentResult Invoke()
        { return View(); }
    }
}
