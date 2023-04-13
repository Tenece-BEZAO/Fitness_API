using System;
using Fitness.BLL.DTO;
using Fitness.DAL.Entities;
using Microsoft.AspNetCore.JsonPatch;

namespace Fitness.BLL.Interface
{
    public interface IExerciseService
    {
        Task<IEnumerable<Exercise>> GetExercises();
        Task<Exercise?> GetExercise(int exerciseId);
        Task CreateExercise(ExercisesDto exerciseDto);
        Task UpdateExercise(int exerciseId, JsonPatchDocument<ExerciseForUpdateDto> jsonPatchDocument);
        Task DeleteExercise(int exerciseId);
    }
}

