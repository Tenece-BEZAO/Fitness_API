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
    public class AchievementsController : Controller
    {
        private readonly IAchievementService _achievementService;
        public AchievementsController(IAchievementService achievementService)
        {
            _achievementService = achievementService;
        }


        [HttpGet("get-all-achievements")]
        [SwaggerOperation(Summary = "Gets all achievements")]
        [SwaggerResponse(StatusCodes.Status200OK, Description = "Gets all Achievements", Type = typeof(SuccessResponse))]
        public async Task<ActionResult<IEnumerable<Achievement>>> GetAllAchievements()
        {
            IEnumerable<Achievement> response = await _achievementService.GetAchievements();
            return Ok(response);
        }

        [AllowAnonymous]
        [HttpGet("get-achievement")]
        [SwaggerOperation(Summary = "Gets achievement with id")]
        [SwaggerResponse(StatusCodes.Status200OK, Description = "Gets achievement with id", Type = typeof(SuccessResponse))]
        public async Task<ActionResult<IEnumerable<Achievement>>> GetAchievement(int Id)
        {
            Achievement response = await _achievementService.GetAchievement(Id);
            return Ok(response);
        }

        [AllowAnonymous]
        [HttpGet("get-user-achievement")]
        [SwaggerOperation(Summary = "Gets achievements tied to a user")]
        [SwaggerResponse(StatusCodes.Status200OK, Description = "Gets item with user id", Type = typeof(SuccessResponse))]
        public async Task<ActionResult<IEnumerable<UserAchievementDto>>> GetUserAchievements(Guid userId)
        {
            IEnumerable<UserAchievementDto> response = await _achievementService.GetUserAchievementsAsync(userId);
            return Ok(response);
        }

        [AllowAnonymous]
        [HttpPost("create-achievement")]
        [SwaggerOperation(Summary = "Creates an achievement")]
        [SwaggerResponse(StatusCodes.Status200OK, Description = "Creates an achievement", Type = typeof(SuccessResponse))]

        public async Task<ActionResult<AchievementsDto>> CreateAchievement(AchievementsDto achievementsDto)
        {
            await _achievementService.CreateAchievement(achievementsDto);
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
        [HttpDelete("delete-achievement")]
        [SwaggerOperation(Summary = "Delete an Achievement")]
        [SwaggerResponse(StatusCodes.Status200OK, Description = "Deletes an achievement", Type = typeof(SuccessResponse))]

        public async Task<ActionResult<Achievement>> DeleteAchievement(int achievementId)
        {
            await _achievementService.DeleteAchievement(achievementId);
            return Ok();
        }



        [AllowAnonymous]
        [HttpPatch("patch-achievement")]
        [SwaggerOperation(Summary = "Patches an Achievement")]
        [SwaggerResponse(StatusCodes.Status200OK, Description = "Achievement patched successfully", Type = typeof(string))]

        public async Task<IActionResult> UpdateAchievement(int Id, JsonPatchDocument<AchievementForUpdateDto> patchDocument)
        {
            await _achievementService.PatchAchievement(Id, patchDocument);
            return Ok();
        }

    }
}

