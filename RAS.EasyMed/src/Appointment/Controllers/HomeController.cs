using Microsoft.AspNetCore.Mvc;

namespace Appointment.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
