using Fitness.BLL.DTO;
using Fitness.BLL.Interface;
using Fitness.DAL.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Fitness.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthenticationController : ControllerBase
    {
        private readonly IAuthService _authService;
        public AuthenticationController(IAuthService authService)
        {
            _authService = authService;
        }

        [HttpPost("LogIn")]
        public async Task<IActionResult> LogIn([FromBody] FitFamerForAuthDTO user)
        {
            var response = await _authService.LogInAsync(user);

            if (!response.IsSuccessful)
                return BadRequest(response);
            return Ok(new
            {
                Token = await _authService.CreateToken()
            });
        }
        [HttpPost("LogOut")]
        public async Task<IActionResult> LogOut()
        {
            var response = await _authService.LogOutAsync();

            if (!response.IsSuccessful)
                return BadRequest(response);
            return Ok();
        }

        
    }
}
