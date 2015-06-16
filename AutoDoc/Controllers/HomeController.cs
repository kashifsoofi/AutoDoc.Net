using Microsoft.AspNet.Mvc;
using AutoDoc.Web.Models;

namespace AutoDoc.Web
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View(CreateUser());
        }

        public User CreateUser()
        {
            User user = new User()
            {
                Name = "Kashif Jamal Soofi",
                Address = "My address"
            };

            return user;
        }
    }
}