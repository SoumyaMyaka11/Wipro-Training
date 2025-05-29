using Microsoft.AspNetCore.Mvc;

namespace WebApplication13.Controllers
{
    public class ContactUsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
