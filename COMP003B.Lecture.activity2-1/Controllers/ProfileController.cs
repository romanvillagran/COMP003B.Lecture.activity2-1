using Microsoft.AspNetCore.Mvc;

namespace COMP003B.Lecture.activity2_1.Controllers
{
    public class ProfileController : Controller
    {
        [HttpGet]
        public IActionResult About()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Hobbies()
        {
            return View();
        }
    }
}
