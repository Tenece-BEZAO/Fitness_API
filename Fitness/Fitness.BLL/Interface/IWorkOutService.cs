using System;
using Fitness.BLL.DTO;
using Fitness.DAL.Entities;
using Microsoft.AspNetCore.JsonPatch;

namespace Fitness.BLL.Interface
{
    public interface IWorkOutService
    {
        Task<IEnumerable<WorkOut>> GetWorkOuts();
        Task DeleteWorkOut(int workOutId);
        Task<IEnumerable<WorkOut>> GetUserWorkOuts(Guid userId);
        Task<WorkOut?> GetWorkOut(int workOutId);
        Task CreateWorkout(WorkOutDto workOutDto);
        Task UpdateWorkOut(int workOutId, JsonPatchDocument<WorkOutForUpdateDto> jsonPatchDocument);
    }
}

