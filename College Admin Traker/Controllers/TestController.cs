using Microsoft.AspNetCore.Mvc;

namespace College_Admin_Traker.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
