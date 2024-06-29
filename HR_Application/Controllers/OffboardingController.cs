using Microsoft.AspNetCore.Mvc;

namespace HR_Application.Controllers
{
    public class OffboardingController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
