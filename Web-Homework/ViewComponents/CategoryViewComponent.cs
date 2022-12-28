using System;
using Microsoft.AspNetCore.Mvc;
using Web_Homework.Repositories;
namespace Web_Homework.ViewComponents
{
    public class CategoryViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            PersonCategoryRepository personCategoryRepository = new PersonCategoryRepository();
            var personCategoryList = personCategoryRepository.TableList();
            return View(personCategoryList);
        }
    }
}

