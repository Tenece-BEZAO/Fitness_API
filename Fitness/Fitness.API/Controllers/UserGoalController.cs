using Microsoft.AspNetCore.Mvc;

namespace Fitness.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserGoalController : ControllerBase
    {
        [HttpPost("CreateAGoal")]
        public IActionResult CreateAGoal()
        {
            return Ok();
        }
        [HttpGet("GetAGoal")]
        public IActionResult GetAGoal()
        {
            return Ok();
        }
        [HttpPatch("UpdateAGoal")]
        public IActionResult UpdateAGoal()
        {
            return Ok();
        }
        [HttpDelete("DeleteAGoal")]
        public IActionResult DeleteAGoal()
        {
            return Ok();
        }
        [HttpGet("GetGoals")]
        public IActionResult GetGoals()
        {
            return Ok();
        }
    }
}
