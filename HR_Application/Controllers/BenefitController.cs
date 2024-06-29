using Microsoft.AspNetCore.Mvc;

namespace HR_Application.Controllers
{
    public class BenefitController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
