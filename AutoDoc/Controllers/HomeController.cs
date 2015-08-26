using Microsoft.AspNet.Mvc;
using AutoDoc.Web.Models;

namespace AutoDoc.Web
{
    [Route("[controller]"), Route("/")]
    public class HomeController : Controller
    {
        [Route("[action]"), Route("")]
        public IActionResult Index()
        {
            return View(CreateUser());
        }

        private User CreateUser()
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