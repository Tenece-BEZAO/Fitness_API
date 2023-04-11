using Fitness.BLL.DTO;
using Fitness.BLL.Interface;
using Microsoft.AspNetCore.Mvc;

namespace Fitness.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost("SignUp")]
        public async Task<IActionResult> SignUp([FromForm] FitFamerForRegistrationDTO user)
        {
            
            var response = await _userService.SignUpAsync(user);

            if (!response.IsSuccessful)
                return BadRequest(response);
            return Ok();
        }

        [HttpPatch("UpdateAccount")]
        public async Task<IActionResult> UpdateUser([FromBody] FitFamerForRegistrationDTO user)
        {
            var response = await _userService.SignUpAsync(user);

            if (!response.IsSuccessful)
                return BadRequest(response);
            return Ok();
        }
        [HttpGet("SearchForAUser")]
        public async Task<IActionResult> SearchForAUser([FromBody] string username)
        {
            var response = await _userService.GetAUserAsync(username);

            if (!response.IsSuccessful)
                return BadRequest(response);
            return Ok();
        }
        [HttpDelete("DeleteAccount")]
        public async Task<IActionResult> DeleteAccount([FromBody] FitFamerForAuthDTO fitfamer)
        {
            var response = await _userService.DeleteAUserAsync(fitfamer);

            if (!response.IsSuccessful)
                return BadRequest(response);
            return Ok();
        }
    }
}
