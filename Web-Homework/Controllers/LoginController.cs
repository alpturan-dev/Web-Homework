using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Web_Homework.Models;
using Web_Homework.Repositories;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Web_Homework.Controllers
{
    public class LoginController : Controller
    {
        private readonly Context context;
        public LoginController(Context _context)
        {
            context = _context;
        }
        PersonRepository personRepository = new PersonRepository();
        // GET: /<controller>/
        [AllowAnonymous]
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [AllowAnonymous]
        [HttpPost]
        public async Task<IActionResult> Index(Person person)
        {
            var data = context.People.FirstOrDefault(item => item.PersonEmail == person.PersonEmail && item.Password == person.Password);
            if (data != null)
            {

                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Email, data.PersonEmail)
                };
                var userIdentity = new ClaimsIdentity(claims, "Login");
                ClaimsPrincipal claimsPrincipal = new ClaimsPrincipal(userIdentity);
                await HttpContext.SignInAsync(claimsPrincipal);
                if (data.RoleID == 2)
                {
                    return RedirectToAction("Index", "Role", data);
                }
                else
                {
                    return RedirectToAction("Index", "Home", data);
                }

            }
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Index", "Home");
        }
        [AllowAnonymous]
        [HttpGet]
        public IActionResult Register()
        {
            List<SelectListItem> listItems = (from item in context.Roles.ToList()
                                              select new SelectListItem
                                              {
                                                  Text = item.RoleName,
                                                  Value = item.RoleID.ToString()
                                              }).ToList();
            ViewBag.listItemsBag = listItems;
            return View();
        }
        [AllowAnonymous]
        [HttpPost]
        public IActionResult Register(Person person)
        {
            personRepository.AddTable(person);
            return RedirectToAction("Index");
        }
    }
}

