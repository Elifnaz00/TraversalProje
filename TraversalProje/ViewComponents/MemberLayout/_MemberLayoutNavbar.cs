using DocumentFormat.OpenXml.Office2010.ExcelAc;
using EntityLayer.Concrate;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace TraversalProje.ViewComponents.MemberLayout
{
    public class _MemberLayoutNavbar:ViewComponent
    {
        private readonly UserManager<AppUser> _userManager;

        public _MemberLayoutNavbar(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
          
            
            var values = await _userManager.FindByNameAsync((User.Identity.Name));
            
            ViewBag.name= values.Name;
            ViewBag.image = values.İmageUrl;

        
            return View();
            
        }  
    }
}
