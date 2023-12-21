using BusinessLayer.Concrate;
using DataAccesLayer.EntityFramework;
using EntityLayer.Concrate;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TraversalProje.Areas.Member.Controllers
{
    [Area("Member")]
    [Route("Member/[controller]/[action]")]
    [Authorize(Roles = "Member")]
    public class ReservationController : Controller
    { 
        DestinationManager destinationManager = new DestinationManager(new EfDestinationDal());
        ReservationManager reservationManager = new ReservationManager(new EfReservationDal());

        private readonly UserManager<AppUser> _userManager;

        public ReservationController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }
        
        [HttpGet]
        public async Task<IActionResult> MyCurrentReservation() 
        {

            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            var valuesList = reservationManager.GetListWithReservationByAccept(values.Id);
            return View(valuesList);
        }
        
        public async Task <IActionResult> MyOldReservation()
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            var valuesList= reservationManager.GetListWithReservationByPrevious(values.Id);

            return View(valuesList);
        }
       
        public async Task <IActionResult> MyApprovalReservation()
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            
            var valuesList= reservationManager.GetListWithReservationByWaitAprroval(values.Id);
            return View(valuesList);
        }


        [HttpGet]
        public IActionResult NewReservation()
        {
            List<SelectListItem> values = (from x in destinationManager.TGetList() 
                                           select new SelectListItem 
                                           { 
                                               Text= x.City,
                                               Value= x.DestinationID.ToString()

                                           }
                                           ).ToList();
            ViewBag.v=values;
            return View();
        }

        [HttpPost]
        public IActionResult NewReservation(Reservation p)
        {
            
            
                p.AppUserId = 4;
                p.Status = "Onay Bekliyor";
                reservationManager.TAdd(p);
                return RedirectToAction("MyCurrentReservation");
            
            
        }

        public IActionResult Deneme()
        { return View(); }
        
    }
        
}
