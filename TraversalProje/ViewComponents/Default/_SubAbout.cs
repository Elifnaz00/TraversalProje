using BusinessLayer.Concrate;
using DataAccesLayer.Concrete;
using DataAccesLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace TraversalProje.ViewComponents.Default
{
    public class _SubAbout:ViewComponent
    {
        SubAboutManager subAboutManager= new SubAboutManager(new EfSubAboutDal()); 


        public IViewComponentResult Invoke()
        {
            
            var subAboutlist = subAboutManager.TGetList();
            return View(subAboutlist);
            
            
        }
    }
}
