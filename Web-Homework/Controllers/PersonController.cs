using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Components.Forms;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Web_Homework.Models;
using Web_Homework.Repositories;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Web_Homework.Controllers
{
    public class PersonController : Controller
    {
        Context context = new Context();
        PersonRepository personRepository = new PersonRepository();

        // GET: /<controller>/
        public IActionResult Index()
        {
            return View(personRepository.TableList("Category"));
        }
        [HttpGet]
        public IActionResult AddPerson()
        {
            List<SelectListItem> listItems = (from item in context.Categories.ToList()
                                              select new SelectListItem
                                              {
                                                  Text = item.CategoryName,
                                                  Value = item.CategoryID.ToString()
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
    }
}

