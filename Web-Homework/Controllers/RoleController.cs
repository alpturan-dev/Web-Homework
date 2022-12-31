using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Web_Homework.Models;
using Web_Homework.Repositories;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Web_Homework.Controllers
{
    public class RoleController : Controller
    {
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

    }
}