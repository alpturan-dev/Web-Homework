using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Web_Homework.Models;
using Web_Homework.Repositories;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Web_Homework.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    [AllowAnonymous]
    public class PersonApiController : ControllerBase
    {
        private static Context _context;
        static PersonRepository personRepository = new PersonRepository();

        // GET: /<controller>/
        public PersonApiController(Context context)
        {
            _context = context;
        }
        [HttpGet]
        public List<Person> GetPerson()
        {
            return personRepository.TableList();
        }
        [HttpGet("{id}")]
        public Person GetPerson(int id)
        {
            return _context.People.SingleOrDefault(item => item.PersonID == id);
        }
        [HttpPost]
        public static Person Post([FromBody] Person person)
        {
            personRepository.AddTable(person);
            return personRepository.FindTable(person.PersonID);

        }
        [HttpPut("{id}")]
        public static void Put(int id, [FromBody] string value)
        {

        }
        [HttpDelete("{id}")]
        public static void Delete(int id)
        {
            var item = _context.People.Find(id);
            if (item != null)
            {
                _context.People.Remove(item);
            }
        }
    }
}

