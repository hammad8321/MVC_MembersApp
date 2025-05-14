using MemberApp_MVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace MemberApp_MVC.Controllers
{
    public class MembersController : Controller
    {
        public IActionResult Overview()
        {
            var mem = new Member()
            {
                Name = "PersonA"
            };
            return View(mem);
        }

        public IActionResult Edit(int id)
        {
            return Content("Member Id" + id);
        
        }
    }
}



//     /members/overview