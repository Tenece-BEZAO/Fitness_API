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
    public class ExerciseController : Controller
    {
        private readonly IExerciseService _exerciseService;
        public ExerciseController(IExerciseService exerciseService)
        {
            _exerciseService = exerciseService;
        }


        [HttpGet("get-all-exercises")]
        [SwaggerOperation(Summary = "Gets all exercises")]
        [SwaggerResponse(StatusCodes.Status200OK, Description = "Gets all Exercises", Type = typeof(SuccessResponse))]
        public async Task<ActionResult<IEnumerable<Exercise>>> GetAllExercises()
        {
            IEnumerable<Exercise> response = await _exerciseService.GetExercises();
            return Ok(response);
        }

        [AllowAnonymous]
        [HttpGet("get-exercise")]
        [SwaggerOperation(Summary = "Gets exercise with id")]
        [SwaggerResponse(StatusCodes.Status200OK, Description = "Gets exercise with id", Type = typeof(SuccessResponse))]
        public async Task<ActionResult<IEnumerable<Exercise>>> GetAExercise(int exerciseId)
        {
            Exercise response = await _exerciseService.GetExercise(exerciseId);
            return Ok(response);
        }



        [AllowAnonymous]
        [HttpPost("create-exercise")]
        [SwaggerOperation(Summary = "Creates an exercise")]
        [SwaggerResponse(StatusCodes.Status200OK, Description = "Creates an exercise", Type = typeof(SuccessResponse))]

        public async Task<ActionResult<Exercise>> CreateExercise(Exercise exercise)
        {
            await _exerciseService.CreateExercise(exercise);
            return Ok();
        }

        //[AllowAnonymous]
        //[HttpPut("update-exercise")]
        //[SwaggerOperation(Summary = "Update an exercise")]
        //[SwaggerResponse(StatusCodes.Status200OK, Description = "Updates an exercise", Type = typeof(SuccessResponse))]

        //public async Task<ActionResult<ExercisesDto>> UpdateExercise(int Id, ExerciseForUpdateDto exerciseForUpdateDto)
        //{
        //    await _exerciseService.UpdateExercise(Id, exerciseForUpdateDto);
        //    return Ok();
        //}

        [AllowAnonymous]
        [HttpDelete("delete-exercise")]
        [SwaggerOperation(Summary = "Delete an Exercise")]
        [SwaggerResponse(StatusCodes.Status200OK, Description = "Deletes an Exercise", Type = typeof(SuccessResponse))]

        public async Task<ActionResult<Exercise>> DeleteExercise(int exerciseId)
        {
            await _exerciseService.DeleteExercise(exerciseId);
            return Ok();
        }



        [AllowAnonymous]
        [HttpPatch("patch-exercise")]
        [SwaggerOperation(Summary = "Patches an exercise")]
        [SwaggerResponse(StatusCodes.Status200OK, Description = "exercise patched successfully", Type = typeof(string))]

        public async Task<IActionResult> UpdateExercise(int Id, JsonPatchDocument<ExerciseForUpdateDto> jsonPatchDocument)
        {
            await _exerciseService.UpdateExercise(Id, jsonPatchDocument);
            return Ok();
        }

    }
}

