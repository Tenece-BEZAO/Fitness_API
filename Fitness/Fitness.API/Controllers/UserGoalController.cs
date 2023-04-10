using Microsoft.AspNetCore.Mvc;
using Fitness.BLL.Interface;
using Fitness.BLL.DTO;

namespace Fitness.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserGoalController : ControllerBase
    {
        private readonly IUserGoalService _userGoalService;
        public UserGoalController(IUserGoalService userGoalService)
        {
            _userGoalService = userGoalService;
        }

        [HttpPost("CreateAGoal")]
        public async Task<IActionResult> CreateAGoal([FromForm]AddOrUpdateUserGoalDTO model)
        {
            var response = await _userGoalService.AddOrUpdateAsync(model);
            if (!response.IsSuccessful)
            {
                return BadRequest(response);
            }
            return Ok();
        }
        [HttpGet("GetAGoal")]
        public async Task<IActionResult> GetAGoal([FromQuery]int fitfamerId, int userId)
        {
            var response = await _userGoalService.GetUserGoalAsync(fitfamerId, userId);
            if (!response.IsSuccessful)
            {
                return BadRequest(response);
            }
            return Ok();
        }
    
        [HttpPatch("UpdateAGoal")]
        public async Task<IActionResult> UpdateAGoal([FromForm]AddOrUpdateUserGoalDTO model)
        {
            var response = await _userGoalService.AddOrUpdateAsync(model);
            if(!response.IsSuccessful)
            {
                return BadRequest(response);
            }
            return Ok();
        }
        [HttpDelete("DeleteAGoal")]
        public async Task<IActionResult> DeleteAGoal([FromBody]FindUserGoalDTO model)
        {
            var response = await _userGoalService.DeleteAsync(model);
            if (!response.IsSuccessful) 
            {
                return BadRequest(response);
            }
            return Ok();
        }
        [HttpGet("GetGoals")]
        public async Task<IActionResult> GetGoals()
        {
            var response =  _userGoalService.GetUserGoalListAsync();
            if (response is not null)
            {
                return BadRequest(response);
            }
            return Ok();
        }
    }
}
