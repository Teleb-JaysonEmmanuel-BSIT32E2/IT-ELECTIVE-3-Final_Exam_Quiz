using Microsoft.AspNetCore.Mvc;

namespace HR_Application.Controllers
{
    public class PayrollController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
