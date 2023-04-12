using System;
using Fitness.BLL.DTO;
using Fitness.DAL.Entities;
using Microsoft.AspNetCore.JsonPatch;

namespace Fitness.BLL.Interface
{
    public interface IWorkOutHistory
    {
        Task<IEnumerable<WorkOutExercise>> GetWorkOutHistory();
        //Task<WorkOutExercise> GetUserWorkOutHistory(int fitFamerId);
        Task CreateWorkOutHistory(WorkOutHistoryDto workOutHistoryDto);
        Task DeleteWorkOutHistory(int workOutHistoryId);
        Task PatchWorkOutHistory(int Id, JsonPatchDocument<WorkOutHistoryForUpdateDto> jsonPatchDocument);
        Task<WorkOutExercise> GetOneWorkOutHistory(int workId);
    }
}

