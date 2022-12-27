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

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Web_Homework.Controllers
{
    public class PersonController : Controller
    {
        Context context = new Context();
        PersonRepository personRepository = new PersonRepository();

        // GET: /<controller>/
        public IActionResult Index(int page = 1)
        {
            return View(personRepository.TableList("PersonCategory").ToPagedList(page, 3));
        }
        [HttpGet]
        public IActionResult AddPerson()
        {
            List<SelectListItem> listItems = (from item in context.PersonCategories.ToList()
                                              select new SelectListItem
                                              {
                                                  Text = item.PersonCategoryName,
                                                  Value = item.PersonCategoryID.ToString()
                                              }).ToList();
            ViewBag.listItemsBag = listItems;
            return View();
        }
        [HttpPost]
        public IActionResult AddPerson(Person person)
        {
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
            List<SelectListItem> listItems = (from item2 in context.PersonCategories.ToList()
                                              select new SelectListItem
                                              {
                                                  Text = item2.PersonCategoryName,
                                                  Value = item2.PersonCategoryID.ToString()
                                              }).ToList();
            ViewBag.listItemsBag = listItems;
            Person person = new Person()
            {
                PersonID = item.PersonID,
                PersonCategoryID = item.PersonCategoryID,
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
            item.PersonName = person.PersonName;
            item.PersonSurname = person.PersonSurname;
            item.PersonPhone = person.PersonPhone;
            item.PersonEmail = person.PersonEmail;
            item.ImageUrl = person.ImageUrl;
            item.PersonCategoryID = person.PersonCategoryID;
            personRepository.UpdateTable(item);
            return RedirectToAction("Index");
        }
    }
}

