using BusinessLayer.Abstract;
using BusinessLayer.Concrate;
using DataAccesLayer.EntityFramework;
using EntityLayer.Concrate;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Windows.Markup;

namespace TraversalProje.Areas.Admin.Controllers
{
    
    [Area("Admin")]
    [Route("Admin/[controller]/[action]")]
    [Authorize(Roles = "Admin")]

    public class DestinationController : Controller
    {
        private readonly IDestinationService _destinationService;

        public DestinationController(IDestinationService destinationService)
        {
            _destinationService = destinationService;
        }
        
        public IActionResult Index()
        {
            var values = _destinationService.TGetList();
            return View(values);
        } 

        [HttpGet]
        public IActionResult AddDestination()
        {

            return View();
        }
       
        [HttpPost]
        public IActionResult AddDestination(Destination destination)
        {
            _destinationService.TAdd(destination);
            return RedirectToAction("Index", "Destination", new { Area = "Admin" });
        }
      
        
        public IActionResult DeleteDestination(int id)
        {
            var values=_destinationService.TGetByID(id);
            _destinationService.TDelete(values);
            return RedirectToAction("Index" ,"Destination", new { Area = "Admin" });
        }

        
        [HttpGet]
        public IActionResult UpdateDestination(int id)
        {
            var values = _destinationService.TGetByID(id);
            return View(values);
        }
        
        [HttpPost]
        public IActionResult UpdateDestination(Destination destination)
        {
            _destinationService.TUpdate(destination);
            return RedirectToAction("Index", "Destination", new { Area = "Admin" });
        }







    }
}
