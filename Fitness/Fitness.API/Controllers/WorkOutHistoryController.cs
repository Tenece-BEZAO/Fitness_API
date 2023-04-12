using System;
using Fitness.BLL.DTO;
using Fitness.BLL.Implementation;
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
    public class WorkOutHistoryController : Controller
    {
        private readonly IWorkOutHistory _workOutHistoryService;
        public WorkOutHistoryController(IWorkOutHistory workOutHistoryService)
        {
            _workOutHistoryService = workOutHistoryService;
        }


        [HttpGet("get-all-workout history")]
        [SwaggerOperation(Summary = "Gets all workout history")]
        [SwaggerResponse(StatusCodes.Status200OK, Description = "Gets all workout history", Type = typeof(SuccessResponse))]
        public async Task<ActionResult<IEnumerable<WorkOutExercise>>> GetAllWorkOutHistory()
        {
            IEnumerable<WorkOutExercise> response = await _workOutHistoryService.GetWorkOutHistory();
            return Ok(response);
        }

        [AllowAnonymous]
        [HttpGet("get-workout history")]
        [SwaggerOperation(Summary = "Gets workout history with id")]
        [SwaggerResponse(StatusCodes.Status200OK, Description = "Gets workout history with id", Type = typeof(SuccessResponse))]
        public async Task<ActionResult<IEnumerable<WorkOutExercise>>> GetWorkOutHistory(int Id)
        {
            WorkOutExercise response = await _workOutHistoryService.GetOneWorkOutHistory(Id);
            return Ok(response);
        }

        //[AllowAnonymous]
        //[HttpGet("get-user-achievement")]
        //[SwaggerOperation(Summary = "Gets achievements tied to a user")]
        //[SwaggerResponse(StatusCodes.Status200OK, Description = "Gets achievement with user id", Type = typeof(SuccessResponse))]
        //public async Task<ActionResult<IEnumerable<UserAchievementDto>>> GetUserAchievements(Guid userId)
        //{
        //    IEnumerable<UserAchievementDto> response = await _achievementService.GetUserAchievementsAsync(userId);
        //    return Ok(response);
        //}

        [AllowAnonymous]
        [HttpPost("create-workout history")]
        [SwaggerOperation(Summary = "Creates a workout history")]
        [SwaggerResponse(StatusCodes.Status200OK, Description = "Creates a workout history", Type = typeof(SuccessResponse))]

        public async Task<ActionResult<WorkOutHistoryDto>> CreateWorkOutHistory(WorkOutHistoryDto workOutHistoryDto)
        {
            await _workOutHistoryService.CreateWorkOutHistory(workOutHistoryDto);
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
        [HttpDelete("delete-workout history")]
        [SwaggerOperation(Summary = "Delete a workout history")]
        [SwaggerResponse(StatusCodes.Status200OK, Description = "Deletes a workout history", Type = typeof(SuccessResponse))]

        public async Task<ActionResult<WorkOutExercise>> DeleteWorkOutHistory(int workOutHistoryId)
        {
            await _workOutHistoryService.DeleteWorkOutHistory(workOutHistoryId);
            return Ok();
        }



        [AllowAnonymous]
        [HttpPatch("patch-workout history")]
        [SwaggerOperation(Summary = "Patches a workout history")]
        [SwaggerResponse(StatusCodes.Status200OK, Description = "workout history patched successfully", Type = typeof(string))]

        public async Task<IActionResult> UpdateWorkOutHistory(int Id, JsonPatchDocument<WorkOutHistoryForUpdateDto> patchDocument)
        {
            await _workOutHistoryService.PatchWorkOutHistory(Id, patchDocument);
            return Ok();
        }

    }
}

