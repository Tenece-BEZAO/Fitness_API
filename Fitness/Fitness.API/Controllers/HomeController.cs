using Fitness.DAL.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Fitness.API.Controllers
{
    public class HomeController : ControllerBase
    {
        public IActionResult Index()
        {
            return Ok();
        }

        [HttpGet] //api/Authentication?Id=2?UniqueId=1111--0000-999?Name=Ngozi
        public IActionResult Index([FromQuery] User user)
        {
            return Ok();
        }

        [HttpPost("addSomethingUp")]
        public IActionResult LogIn([FromBody] User user)
        {
            return Ok();
        }

        [HttpPost("Sendto/{id}/me")]
        public ActionResult LogOut([FromForm] User user, int id)
        {
            return Ok();
        }
    }
}
