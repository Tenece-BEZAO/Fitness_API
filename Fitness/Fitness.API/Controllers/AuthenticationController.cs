using Microsoft.AspNetCore.Mvc;

namespace Fitness.API.Controllers
{
    public class AuthenticationController : Controller
    {
        public AuthenticationController()
        {
            
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
