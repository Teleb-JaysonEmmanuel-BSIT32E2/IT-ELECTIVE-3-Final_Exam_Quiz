using Microsoft.AspNetCore.Mvc;

namespace HR_Application.Controllers
{
    public class OnboardingController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
