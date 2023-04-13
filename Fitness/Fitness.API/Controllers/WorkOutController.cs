using System;
using Fitness.BLL.DTO;
using Fitness.BLL.Infrastructure;
using Fitness.BLL.Interface;
using Fitness.DAL.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace Fitness.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WorkOutController : Controller
    {
        private readonly IWorkOutService _workOutService;
        public WorkOutController(IWorkOutService workOutService)
        {
            _workOutService = workOutService;
        }


        [HttpGet("get-all-workout")]
        [SwaggerOperation(Summary = "Gets all workout")]
        [SwaggerResponse(StatusCodes.Status200OK, Description = "Gets all Workout", Type = typeof(SuccessResponse))]
        public async Task<ActionResult<IEnumerable<WorkOut>>> GetAllWorkOut()
        {
            IEnumerable<WorkOut> response = await _workOutService.GetWorkOuts();
            return Ok(response);
        }

        [AllowAnonymous]
        [HttpGet("get-workout")]
        [SwaggerOperation(Summary = "Gets workout with id")]
        [SwaggerResponse(StatusCodes.Status200OK, Description = "Gets workout with id", Type = typeof(SuccessResponse))]
        public async Task<ActionResult<IEnumerable<WorkOut>>> GetWorkOut(int workOutId)
        {
            WorkOut response = await _workOutService.GetWorkOut(workOutId);
            return Ok(response);
        }

        [AllowAnonymous]
        [HttpGet("get-user-workout")]
        [SwaggerOperation(Summary = "Gets workout tied to a user")]
        [SwaggerResponse(StatusCodes.Status200OK, Description = "Gets item with user id", Type = typeof(SuccessResponse))]
        public async Task<ActionResult<IEnumerable<WorkOutDto>>> GetUserWorkOuts(Guid userId)
        {
            IEnumerable<WorkOut> response = await _workOutService.GetUserWorkOuts(userId);
            return Ok(response);
        }

        [AllowAnonymous]
        [HttpPost("create-workout")]
        [SwaggerOperation(Summary = "Logs in workout for the day")]
        [SwaggerResponse(StatusCodes.Status200OK, Description = "logs in workout for the day", Type = typeof(SuccessResponse))]

        public async Task<ActionResult<WorkOutDto>> CreateWorkOut(WorkOutDto workOutDto)
        {
            await _workOutService.CreateWorkout(workOutDto);
            return Ok();
        }

        //[AllowAnonymous]
        //[HttpPut("update-achievement")]
        //[SwaggerOperation(Summary = "Update a to do item")]
        //[SwaggerResponse(StatusCodes.Status200OK, Description = "Updates a to do item", Type = typeof(SuccessResponse))]

        //public async Task<ActionResult<AchievementsDto>> UpdateAchievement(int Id, AchievementForUpdateDto achievementForUpdateDto)
        //{
        //    await _achievementService.UpdateAchievement(Id, achievementForUpdateDto);
        //    return Ok();
        //}

        [AllowAnonymous]
        [HttpDelete("delete-workout")]
        [SwaggerOperation(Summary = "Delete a workout")]
        [SwaggerResponse(StatusCodes.Status200OK, Description = "Deletes a workout", Type = typeof(SuccessResponse))]

        public async Task<ActionResult<WorkOut>> DeleteWorkOut(int workOutId)
        {
            await _workOutService.DeleteWorkOut(workOutId);
            return Ok();
        }



        [AllowAnonymous]
        [HttpPatch("patch-workout")]
        [SwaggerOperation(Summary = "Patches a workout")]
        [SwaggerResponse(StatusCodes.Status200OK, Description = "workout patched successfully", Type = typeof(string))]

        public async Task<IActionResult> UpdateWorkout(int workOutId, JsonPatchDocument<WorkOutForUpdateDto> patchDocument)
        {
            await _workOutService.UpdateWorkOut(workOutId, patchDocument);
            return Ok();
        }

    }
}

