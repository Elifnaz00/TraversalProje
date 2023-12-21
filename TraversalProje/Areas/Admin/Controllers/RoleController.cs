using EntityLayer.Concrate;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TraversalProje.Areas.Admin.Models;

namespace TraversalProje.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/Role")]
    [AllowAnonymous]
    public class RoleController : Controller
    {
        private readonly RoleManager<AppRole> _roleManager;
        private readonly UserManager<AppUser> _userManager;

        public RoleController(RoleManager<AppRole> roleManager, UserManager<AppUser> userManager)
        {
            _roleManager = roleManager;
            _userManager = userManager;
        }

        [Route("Index")]
        public IActionResult Index()
        {
            var values = _roleManager.Roles.ToList();
            return View(values);

        }

        [Route("CreateRole")]
        [HttpGet]
        public IActionResult CreateRole()
        {

            return View();

        }

        [Route("CreateRole")]
        [HttpPost]
        public async Task<IActionResult> CreateRole(CreateRoleViewModel model)
        {
            var result= await _roleManager.CreateAsync(new AppRole
            {
                Name= model.RoleName,
            });
            if(result.Succeeded) 
            { 
                return RedirectToAction("Index");
            }
            else
            return View();
        }


        [Route("UpdateRole/{id}")]
        [HttpGet]
        public IActionResult UpdateRole(int id)
        {
            var result = _roleManager.Roles.FirstOrDefault(x => x.Id == id);
            UpdateRoleViewModel updateRoleModel = new UpdateRoleViewModel()
            {
                RoleID = id,
                RoleName= result.Name,
            };
            return View(updateRoleModel);

        }

        [Route("UpdateRole/{id}")]
        [HttpPost]
        public async Task <IActionResult> UpdateRole(UpdateRoleViewModel model)
        {

           var value= _roleManager.Roles.FirstOrDefault(x=> x.Id == model.RoleID);
           value.Name = model.RoleName;
           await _roleManager.UpdateAsync(value);
            return RedirectToAction("Index");

        } 

        [Route("DeleteRole/{id}")]
        public async Task<IActionResult> DeleteRole(int id)
        {
            var value= _roleManager.Roles.FirstOrDefault(x => x.Id==id);    
            await _roleManager.DeleteAsync(value);
            return RedirectToAction("Index");

        }


        [Route("UserList")]
        public async Task<IActionResult> UserList()
        {
            var users = await _userManager.Users.ToListAsync();

            return View(users);
        }


        [Route("AssignRole/{id}")]
        [HttpGet]
        public async Task<IActionResult> AssignRole(int id)
        {
            var user = _userManager.Users.FirstOrDefault(x => x.Id == id);
            TempData["Userid"] = user.Id;
            var roles = _roleManager.Roles.ToList();
            var userRoles = await _userManager.GetRolesAsync(user);
            List<RoleAssignViewModel> roleAssignViewModels = new List<RoleAssignViewModel>();
            foreach (var item in roles)
            {
                RoleAssignViewModel model = new RoleAssignViewModel();
                model.RoleId = item.Id;
                model.RoleName = item.Name;
                model.RoleExist = userRoles.Contains(item.Name);
                roleAssignViewModels.Add(model);
            }
            return View(roleAssignViewModels);
        }
    }
}
