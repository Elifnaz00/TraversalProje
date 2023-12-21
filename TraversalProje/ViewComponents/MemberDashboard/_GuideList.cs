using BusinessLayer.Concrate;
using DataAccesLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace TraversalProje.ViewComponents.MemberDashboard
{
    public class _GuideList:ViewComponent
    {
        GuideManager _guideManager = new GuideManager(new EfGuideDal());

        public IViewComponentResult Invoke()
        {
            var values= _guideManager.TGetList();

            return View(values); 
            
        }
    }
}
