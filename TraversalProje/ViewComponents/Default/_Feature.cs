using BusinessLayer.Concrate;
using DataAccesLayer.Abstract;
using DataAccesLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata.Ecma335;

namespace TraversalProje.ViewComponents
{
    public class _Feature : ViewComponent
    {
        FeatureManager featureManager = new FeatureManager(new EfFeatureDal());
        public IViewComponentResult Invoke()
        {
            //var featureList = featureManager.TGetList();
            //ViewBag.image1=
            return View();
        }
    }
}
