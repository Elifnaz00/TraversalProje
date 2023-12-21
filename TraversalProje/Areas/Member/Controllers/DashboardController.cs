using EntityLayer.Concrate;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace TraversalProje.Areas.Member.Controllers
{
    [Authorize(Roles = "Member")]
    [Area("Member")]
    [Route("Member/[controller]/[action]")]
    public class DashboardController : Controller
    {
        public readonly UserManager<AppUser> _userManager;

        public DashboardController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        
        public async Task<IActionResult> Index()
        {
            var values =await _userManager.FindByNameAsync(User.Identity.Name);
            ViewBag.name = values.Name + " " + values.SurName;
            ViewBag.UserImage = values.İmageUrl;
            return View();
        }

        public async Task<IActionResult> MemberDashboard()
        {
            return View();
        }

    }
}
