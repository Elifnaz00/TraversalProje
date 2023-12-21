using BusinessLayer.Abstract;
using EntityLayer.Concrate;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace TraversalProje.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    [Route("Admin/[controller]/[action]")]

    public class UserController : Controller
    {
        private readonly IAppUserService _appUserService;
        private readonly IReservationService _rezervationService;

      
        public UserController(IAppUserService appUserService, IReservationService rezervationService) 
        {
            _appUserService = appUserService;
            _rezervationService = rezervationService;
        }
        
        public IActionResult Index()
        {
            var values= _appUserService.TGetList();
            return View(values);
        } 

        public IActionResult DeleteUser(int id) 
        {
            var values= _appUserService.TGetByID(id);
            _appUserService.TDelete(values);
            return View("Index"); 
        }
        [HttpGet]
        public IActionResult EditUser(int id)
        {
            var values= _appUserService.TGetByID(id);

            return View(values);
        }
        
        [HttpPost]
        public IActionResult EditUser(AppUser appuser)
        {
            _appUserService.TUpdate(appuser);

            return RedirectToAction("Index" ,"User", new { Area = "Admin" });   
        } 
        
        public IActionResult CommentUser(int id)
        {
            _appUserService.TGetList();
            return View();
        } 
        public IActionResult RezervationUser(int id)
        {
            var values= _rezervationService.GetListWithReservationByAccept(id);
            return View(values);
            
        }



    }
}
