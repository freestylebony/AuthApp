using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AuthApp.Controllers
{   
    [Authorize]
    public class TestController : Controller
    {
        public IActionResult Secret()
        {
            return View();
        }
    }
}
