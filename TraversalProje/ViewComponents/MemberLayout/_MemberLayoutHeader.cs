using Microsoft.AspNetCore.Mvc;

namespace TraversalProje.ViewComponents.MemberLayout
{
    public class _MemberLayoutHeader:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
