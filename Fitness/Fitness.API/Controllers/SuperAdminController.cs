using Microsoft.AspNetCore.Mvc;

namespace Fitness.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SuperAdminController : ControllerBase
    {
        [HttpPost("CreateAUser")]
        public IActionResult CreateAUser()
        {
            return Ok();
        }
        [HttpPatch("UpdateAUser")]
        public IActionResult UpdateAUser()
        {
            return Ok();
        }
        [HttpDelete("DeleteAUser")]
        public IActionResult DeleteAUser()
        {
            return Ok();
        }
        [HttpGet("GetAUser")]
        public IActionResult GetAUser()
        {
            return Ok();
        }
        [HttpGet("GetAListOfUsers")]
        public IActionResult GetUsers()
        {
            return Ok();
        }
        [HttpGet("AddOrRemoveAdmin")]
        public IActionResult ToggleAdmin()
        {
            return Ok();
        }
    }
}
