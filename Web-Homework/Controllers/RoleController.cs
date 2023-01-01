using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Web_Homework.Models;
using Web_Homework.Repositories;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Web_Homework.Controllers
{
    public class RoleController : Controller
    {
        Context context = new Context();

        RoleRepository roleRepository = new RoleRepository();

        public IActionResult Index()
        {
            return View(roleRepository.TableList());
        }
        [HttpGet]
        public IActionResult AddRole()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddRole(Role role)
        {
            //Anlamadim burayi sonra bakariz.
            //if (!ModelState.IsValid)
            //{
            //    return View("AddCategory");
            //}
            roleRepository.AddTable(role);
            return RedirectToAction("Index");
        }
        public IActionResult DeleteRole(int id)
        {
            roleRepository.DeleteTable((new Role { RoleID = id }));
            return RedirectToAction("Index");
        }
        //public IActionResult GetRole(int id)
        //{
        //    var item = roleRepository.FindTable(id);
        //    List<SelectListItem> listItems = (from item2 in context.Roles.ToList()
        //                                      select new SelectListItem
        //                                      {
        //                                          Text = item2.RoleName,
        //                                          Value = item2.RoleID.ToString()
        //                                      }).ToList();
        //    ViewBag.listItemsBag = listItems;
        //    Role role = new Role()
        //    {
        //        RoleName = item.RoleName,
        //        RoleDescription = item.RoleDescription
        //    };
        //    return View(role);
        //}
        //[HttpPost]
        //public IActionResult UpdateRole(Role role)
        //{
        //    var item = roleRepository.FindTable(role.RoleID);
        //    item.RoleName = role.RoleName;
        //    item.RoleDescription = role.RoleDescription;
        //    roleRepository.UpdateTable(item);
        //    return RedirectToAction("Index");
        //}

    }
}