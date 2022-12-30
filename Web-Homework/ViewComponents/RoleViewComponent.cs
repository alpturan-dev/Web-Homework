using System;
using Microsoft.AspNetCore.Mvc;
using Web_Homework.Repositories;
namespace Web_Homework.ViewComponents
{
    public class RoleViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            RoleRepository roleRepository = new RoleRepository();
            var roleList = roleRepository.TableList();
            return View(roleList);

        }
    }
}

