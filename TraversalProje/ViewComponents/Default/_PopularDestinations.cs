using BusinessLayer.Concrate;
using DataAccesLayer.Abstract;
using DataAccesLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace TraversalProje.ViewComponents.Default
{
    public class _PopularDestinations:ViewComponent
    {
        DestinationManager destinationManager = new DestinationManager(new EfDestinationDal());
        
        public IViewComponentResult Invoke()
        { 
            var values= destinationManager.TGetList();
            return View(values);
            
           
        }
    }
}
