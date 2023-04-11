using System;
using Fitness.BLL.DTO;
using Fitness.DAL.Entities;
using Microsoft.AspNetCore.JsonPatch;

namespace Fitness.BLL.Interface
{
    public interface IAchievementService
    {
        Task<IEnumerable<Achievement>> GetAchievements();
        Task<Achievement> GetAchievement(int Id);
        Task<IEnumerable<UserAchievementDto>> GetUserAchievementsAsync(Guid userId);
        Task CreateAchievement(AchievementsDto achievementsDto);
        Task UpdateAchievement(int achievementId, AchievementForUpdateDto achievementForUpdateDto);
        Task DeleteAchievement(int achievementId);
        Task PatchAchievement(int Id, JsonPatchDocument<AchievementForUpdateDto> jsonPatchDocument);

    }
}

