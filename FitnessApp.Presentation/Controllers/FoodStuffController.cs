using Fitness.BLL.DTO.Requests;
using Fitness.BLL.DTO.Responses;
using Fitness.BLL.Infrastructure;
using Fitness.BLL.Interface;
using Fitness.DAL.Entities;
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
    //[Authorize(Policy = "Authorization")]
    public class FoodStuffController : ControllerBase
    {
        private readonly IFoodStuffService _foodStuffService;

        public FoodStuffController(IFoodStuffService foodStuffService)
        {
            _foodStuffService = foodStuffService;
        }

        [AllowAnonymous]
        [HttpPost("add-food-stuff")]
        [SwaggerOperation(Summary = "Adds a food stuff")]
        [SwaggerResponse(StatusCodes.Status200OK, Description = "Adds a meal log", Type = typeof(SuccessResponse))]
        [SwaggerResponse(StatusCodes.Status400BadRequest, Description = "Invalid username or password", Type = typeof(ErrorResponse))]
        [SwaggerResponse(StatusCodes.Status500InternalServerError, Description = "It's not you, it's us", Type = typeof(ErrorResponse))]
        public async Task<ActionResult<FoodStuffResponse>> AddFoodStuff(FoodStuffRequest request)
        {
            await _foodStuffService.AddFoodStuff(request);
            return Ok();
        }

        [AllowAnonymous]
        [HttpDelete("delete-food-stuff")]
        [SwaggerOperation(Summary = "Delete food stuff")]
        [SwaggerResponse(StatusCodes.Status200OK, Description = "Deletes food stuff", Type = typeof(SuccessResponse))]
        [SwaggerResponse(StatusCodes.Status400BadRequest, Description = "Invalid username or password", Type = typeof(ErrorResponse))]
        [SwaggerResponse(StatusCodes.Status500InternalServerError, Description = "It's not you, it's us", Type = typeof(ErrorResponse))]
        public async Task<ActionResult<FoodStuffResponse>> DeleteFoodStuff(string name)
        {
            await _foodStuffService.DeleteFoodStuff(name);
            return Ok();
        }

        [AllowAnonymous]
        [HttpPut("update-food-stuff")]
        [SwaggerOperation(Summary = "Update food stuff")]
        [SwaggerResponse(StatusCodes.Status200OK, Description = "Updates a food stuff", Type = typeof(SuccessResponse))]
        [SwaggerResponse(StatusCodes.Status400BadRequest, Description = "Invalid username or password", Type = typeof(ErrorResponse))]
        [SwaggerResponse(StatusCodes.Status500InternalServerError, Description = "It's not you, it's us", Type = typeof(ErrorResponse))]
        public async Task<ActionResult<FoodStuffResponse>> UpdateFoodStuff(string name, FoodStuffRequest request)
        {
            await _foodStuffService.UpdateFoodStuff(name, request);
            return Ok();
        }

        [HttpGet("get-all-food-stuff")]
        [SwaggerOperation(Summary = "Gets all items in the foodstuff table")]
        [SwaggerResponse(StatusCodes.Status200OK, Description = "Gets all foodstuff", Type = typeof(SuccessResponse))]
        [SwaggerResponse(StatusCodes.Status400BadRequest, Description = "Invalid username or password", Type = typeof(ErrorResponse))]
        [SwaggerResponse(StatusCodes.Status500InternalServerError, Description = "It's not you, it's us", Type = typeof(ErrorResponse))]
        public async Task<ActionResult<IEnumerable<FoodStuff>>> ViewAllFoodStuff()
        {
            IEnumerable<FoodStuff> response = await _foodStuffService.ViewFoodStuffs();
            return Ok(response);
        }
    }
}
