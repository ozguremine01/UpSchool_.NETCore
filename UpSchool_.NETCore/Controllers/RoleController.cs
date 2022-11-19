using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;
using UpSchool.EntityLayer.Concrete;
using UpSchool_.NETCore.Models;

namespace UpSchool_.NETCore.Controllers
{
    public class RoleController : Controller
    {

        private readonly RoleManager<AppRole> _roleManager;

        public RoleController(RoleManager<AppRole> roleManager)
        {
            _roleManager = roleManager;
        }

        public IActionResult Index()
        {
            var values = _roleManager.Roles.ToList();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddRole()
        {
            return View();
        }

        //[HttpPost]
        /*
        public async Task<IActionResult> AddRole(RoleViewModel model)
        {
            if(ModelState.IsValid)
            {
                AppRole appRole = new AppRole()
                {
                    Name = model.RoleName
                };
                var result = await _roleManager.CreateAsync(appRole);
                if(result.Succeeded)
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    foreach(var item in result.Errors)
                    {
                        ModelState.AddModelError("",item.Description);

                    }
                }
            }
            return View();
        }
        */
        /*
        public async Task<IActionResult> DeleteRole()
        {
            var role = _roleManager.Roles.FirstOrDefault(x => x.Id == id);
            var result = await _roleManager.DeleteAsync(role);  
            if(result.Succeeded)
            {
                return RedirectToAction("Index");
            }
            return View();
        }
        */

    }
}
