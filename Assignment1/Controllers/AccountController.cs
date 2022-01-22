using Assignment1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Assignment1.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult SignUp()
        {
            return View();
        }
        [HttpPost]
        public IActionResult SignUp(UserModel model)
        {           
            if (ModelState.IsValid)
            {
                return RedirectToAction("Message");
            }
            return View();
        }

        public IActionResult Message()
        {

            return View();
        }
    }
}
