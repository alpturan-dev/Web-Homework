using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Web_Homework.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Web_Homework.Controllers
{
    public class LoginController : Controller
    {
        Context context = new Context();
        // GET: /<controller>/
        [AllowAnonymous]
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [AllowAnonymous]
        [HttpPost]
        public async Task<IActionResult> Index(Admin parameter)
        {
            ViewBag.email = parameter.Email;
            var userdata = context.Admins.FirstOrDefault(item => item.Email == parameter.Email && item.Password == parameter.Password);
            if (userdata != null)
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Email, parameter.Email)
                };
                var userIdentity = new ClaimsIdentity(claims, "Login");
                ClaimsPrincipal claimsPrincipal = new ClaimsPrincipal(userIdentity);
                await HttpContext.SignInAsync(claimsPrincipal);
                return RedirectToAction("Index", "Role");
            }
            return View();
        }
        //[AllowAnonymous]
        //[HttpPost]
        //public async Task<IActionResult> Index(Person parameter)
        //{
        //    ViewBag.email = parameter.PersonEmail;
        //    var userdata = context.People.FirstOrDefault(item => item.PersonEmail == parameter.PersonEmail && item.PersonEmail == parameter.PersonEmail);
        //    if (userdata != null)
        //    {
        //        var claims = new List<Claim>
        //        {
        //            new Claim(ClaimTypes.Email, parameter.PersonEmail)
        //        };
        //        var userIdentity = new ClaimsIdentity(claims, "Login");
        //        ClaimsPrincipal claimsPrincipal = new ClaimsPrincipal(userIdentity);
        //        await HttpContext.SignInAsync(claimsPrincipal);
        //        return RedirectToAction("Index", "Role");
        //    }
        //    return View();
        //    //person icin login isleminde kaldik
        //}
        [HttpGet]
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Index", "Home");
        }
    }
}

