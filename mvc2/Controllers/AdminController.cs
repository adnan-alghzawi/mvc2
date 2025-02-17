using Microsoft.AspNetCore.Mvc;

namespace mvc2.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Admin()
        {
            return View();
        }
    }
}
