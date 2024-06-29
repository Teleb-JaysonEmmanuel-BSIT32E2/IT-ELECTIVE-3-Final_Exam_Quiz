using Microsoft.AspNetCore.Mvc;

namespace HR_Application.Controllers
{
    public class CompensationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
