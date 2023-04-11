using Fitness.BLL.DTO.Requests;
using Fitness.DAL.Entities;

namespace Fitness.BLL.Interface
{
    public interface IMealLogService
    {
        Task AddMealLog(MealLogRequest request);
        Task DeleteMealLog(Guid mealLogId);
        Task UpdateMealLog(Guid mealLogId);
        Task GetMealLog(Guid mealLogId);
        Task<IEnumerable<MealLog>> GetMealLogByDate(Guid fitfamerId, DateTime date);

    }
}
