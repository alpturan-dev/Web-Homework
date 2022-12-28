using System;
using Microsoft.AspNetCore.Mvc;
using Web_Homework.Repositories;
namespace Web_Homework.ViewComponents
{
    public class FilteredCategoryViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(int id)
        {
            PersonRepository personRepository = new PersonRepository();
            var personList = personRepository.FilteredTable(item => item.PersonCategoryID == id);
            return View(personList);
        }
    }
}

