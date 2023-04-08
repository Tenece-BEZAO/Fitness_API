using Fitness.BLL.DTO.Requests;
using Fitness.BLL.DTO.Responses;
using Fitness.BLL.Implementation;
using Fitness.BLL.Infrastructure;
using Fitness.BLL.Interface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessApp.Presentation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MealLogController : ControllerBase
    {
        private readonly IMealLogService _mealLogService;

        public MealLogController(IMealLogService mealLogService)
        {
            _mealLogService = mealLogService;
        }

        [AllowAnonymous]
        [HttpPost("add-meal-log")]
        [SwaggerOperation(Summary = "Adds a meal log")]
        [SwaggerResponse(StatusCodes.Status200OK, Description = "Adds a meal log", Type = typeof(SuccessResponse))]
        [SwaggerResponse(StatusCodes.Status400BadRequest, Description = "Invalid username or password", Type = typeof(ErrorResponse))]
        [SwaggerResponse(StatusCodes.Status500InternalServerError, Description = "It's not you, it's us", Type = typeof(ErrorResponse))]
        public async Task<OkResult> AddUserMealLog(MealLogRequest request)
        {
            await _mealLogService.AddMealLog(request);
            return Ok();
        }
    }
}
