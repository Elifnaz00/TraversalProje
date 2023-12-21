using BusinessLayer.Abstract;
using BusinessLayer.Concrate;
using DataAccesLayer.Concrete;
using DataAccesLayer.EntityFramework;
using EntityLayer.Concrate;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace TraversalProje.Controllers
{
    [AllowAnonymous]
   
    public class DestinationController : Controller
    {

        private readonly IDestinationService _destinationService;
        
        private readonly UserManager<AppUser> _userManager;

        public DestinationController(UserManager<AppUser> userManager, IDestinationService destinationService)
        {
            _userManager = userManager;
            _destinationService = destinationService;
        }

        public IActionResult Index()
        {

            var values = _destinationService.TGetList();

            return View(values);
         
        }

        [HttpGet]
        public async Task<IActionResult> DestinationDetails(int id)
        {
            ViewBag.i = id;
            ViewBag.destID = id;

            if(User.Identity.IsAuthenticated) 
            {
                var value = await _userManager.FindByNameAsync(User.Identity.Name);
                ViewBag.userID = value.Id;
            }
            
            var valuee= _destinationService.TGetDestinationWithGuide(id);
            return View(valuee);
           
        }
        
        [HttpPost]
        public IActionResult DestinationDetails(Destination p)
        {
            return View();
        }


    }
}
