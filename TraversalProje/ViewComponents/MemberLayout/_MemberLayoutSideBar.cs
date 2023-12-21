using Microsoft.AspNetCore.Mvc;

namespace TraversalProje.ViewComponents.MemberLayout
{
    public class _MemberLayoutSideBar:ViewComponent
    {
        public IViewComponentResult Invoke()
        { return View(); }
    }
}
