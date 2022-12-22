using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Web_Homework.Repositories;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Web_Homework.Controllers
{
    public class PersonController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            PersonRepository personRepository = new PersonRepository();
            return View(personRepository.TableList("Category"));
        }
    }
}

