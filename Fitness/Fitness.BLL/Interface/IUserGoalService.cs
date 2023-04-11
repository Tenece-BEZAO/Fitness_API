using Fitness.BLL.DTO;
using Fitness.DAL.Entities;

namespace Fitness.BLL.Interface
{
    public interface IUserGoalService
    {
        public Task<Response<AddOrUpdateUserGoalDTO>> AddOrUpdateAsync(AddOrUpdateUserGoalDTO model);
        public Task<Response<FindUserGoalDTO>> DeleteAsync(FindUserGoalDTO model);
        public Task<Response<UserGoal>> GetUserGoalAsync(int fitfamerId, int userGoalId);
        public IEnumerable<UserGoal> GetUserGoalListAsync();
    }
}
