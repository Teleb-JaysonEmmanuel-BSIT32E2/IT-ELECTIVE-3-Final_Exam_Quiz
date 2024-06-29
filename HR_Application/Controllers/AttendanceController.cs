using Microsoft.AspNetCore.Mvc;

namespace HR_Application.Controllers
{
    public class AttendanceController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
