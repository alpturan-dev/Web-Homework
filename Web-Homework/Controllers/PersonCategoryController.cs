using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Web_Homework.Models;
using Web_Homework.Repositories;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Web_Homework.Controllers
{
    public class PersonCategoryController : Controller
    {
        PersonCategoryRepository personCategoryRepository = new PersonCategoryRepository();

        public IActionResult Index()
        {
            return View(personCategoryRepository.TableList());
        }
        [HttpGet]
        public IActionResult AddPersonCategory()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddPersonCategory(PersonCategory personCategory)
        {
            //Anlamadim burayi sonra bakariz.
            //if (!ModelState.IsValid)
            //{
            //    return View("AddCategory");
            //}
            personCategoryRepository.AddTable(personCategory);
            return RedirectToAction("Index");
        }

    }
}