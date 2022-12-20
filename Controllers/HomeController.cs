using Microsoft.AspNetCore.Mvc;

namespace CmdProfect.Controllers
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
    public class HomeController : Controller
    {
        private Person _person = new Person() { FirstName = "Yakov", LastName = "Sereb"};

        public IActionResult Index()
        {
            return View(_person);
        }

        public IActionResult Show(int id)
        {
            if (id < 0)
                return BadRequest("Id cannot be negative");
            if (id == 10)
                return Content("Hello Show");
            return this.NotFound();
        }
    }
}
