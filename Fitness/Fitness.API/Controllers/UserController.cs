
﻿using Fitness.BLL.DTO;
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

        /*[HttpPost("SignUp")]
        public async Task<IActionResult> SignUp([FromBody] FitFamerForRegistrationDTO user)
        {

            var response = await _userService.SignUpAsync(user);

            if (!response.IsSuccessful)
                return BadRequest(response);
            return Ok();
        }*/

