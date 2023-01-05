using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Components.Forms;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Web_Homework.Models;
using Web_Homework.Repositories;
using X.PagedList;
using Microsoft.AspNetCore.Authorization;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Web_Homework.Controllers
{
    public class PersonController : Controller
    {
        private readonly Context context;
        public PersonController(Context _context)
        {
            context = _context;
        }

        PersonRepository personRepository = new PersonRepository();

        // GET: /<controller>/
        public IActionResult Index(Person person, int page = 1)
        {
            ViewBag.personID = person.PersonID;
            return View(personRepository.TableList("Role").ToPagedList(page, 10));
        }
        [HttpGet]
        public IActionResult AddPerson()
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
        [HttpPost]
        public IActionResult AddPerson(Person person)
        {
            person.Password = RandomPass();
            personRepository.AddTable(person);
            return RedirectToAction("Index");
        }
        public IActionResult DeletePerson(int id)
        {
            personRepository.DeleteTable((new Person { PersonID = id }));
            return RedirectToAction("Index");
        }
        public IActionResult GetPerson(int id)
        {
            var item = personRepository.FindTable(id);
            List<SelectListItem> listItems = (from item2 in context.Roles.ToList()
                                              select new SelectListItem
                                              {
                                                  Text = item2.RoleName,
                                                  Value = item2.RoleID.ToString()
                                              }).ToList();
            ViewBag.listItemsBag = listItems;
            Person person = new Person()
            {
                PersonID = item.PersonID,
                RoleID = item.RoleID,
                PersonName = item.PersonName,
                PersonSurname = item.PersonSurname,
                PersonPhone = item.PersonPhone,
                PersonEmail = item.PersonEmail,
                ImageUrl = item.ImageUrl
            };
            return View(person);
        }
        [HttpPost]
        public IActionResult UpdatePerson(Person person)
        {
            var item = personRepository.FindTable(person.PersonID);
            if (item != null)
            {
                item.PersonName = person.PersonName;
                item.PersonSurname = person.PersonSurname;
                item.PersonPhone = person.PersonPhone;
                item.PersonEmail = person.PersonEmail;
                item.ImageUrl = person.ImageUrl;
                item.RoleID = person.RoleID;
                personRepository.UpdateTable(item);
                return RedirectToAction("Index");
            }
            return RedirectToAction("Index");

        }
        public IActionResult RoleDetails(int id)
        {
            ViewBag.x = id;
            return View();
        }

        public static string RandomPass()
        {
            Random random = new Random();
            int random1 = random.Next(0, 10);
            int random2 = random.Next(0, 10);
            int random3 = random.Next(0, 10);
            int random4 = random.Next(0, 10);
            int random5 = random.Next(0, 10);
            string pass = random1.ToString() + random2.ToString() + random3.ToString() + random4.ToString() + random5.ToString();
            return pass;
        }
    }
}

