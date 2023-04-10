using Fitness.BLL.DTO;
using Fitness.BLL.Interface;
using Fitness.DAL.Entities;

namespace Fitness.BLL.Implementation
{
    public class UserGoalService : IUserGoalService
    {
        private readonly IRepository<FitFamer> _repo;
        private readonly IUnitOfWork _unitOfWork;

        public UserGoalService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _repo = _unitOfWork.GetRepository<FitFamer>();

        }
        public async Task<Response<AddOrUpdateUserGoalDTO>> AddOrUpdateAsync(AddOrUpdateUserGoalDTO model)
        {
            FitFamer fitFamer = await _repo.GetSingleByAsync(f => f.Id == model.FitFamerId);

            if (fitFamer is null)
            {
                return new Response<AddOrUpdateUserGoalDTO> { IsSuccessful = false, Message = $"User with id:{model.FitFamerId} wasn't found" };
            }

            UserGoal userGoal = fitFamer.UserGoals.SingleOrDefault(u => u.Id == model.UserGoalID);

            if (userGoal is not null)
            {
                userGoal.UpdatedAt = DateTime.Now;
                userGoal.StartDate = model.StartDate;
                userGoal.Status = model.Status;
                userGoal.TargetWeight = model.TargetWeight;
                userGoal.EndDate = model.EndDate;
                userGoal.ExpectedDailyCalorieBurnt = model.ExpectedDailyCalorieBurnt;
                userGoal.ExpectedDailyCalorieIntake = model.ExpectedDailyCalorieIntake;
                userGoal.GoalType = model.GoalType;

                await _unitOfWork.SaveChangesAsync();
                return new Response<AddOrUpdateUserGoalDTO> { IsSuccessful = true, Message = "Update Successful!" };
            }
            else
            {

                userGoal.CreatedAt = DateTime.Now;
                userGoal.StartDate = model.StartDate;
                userGoal.Status = model.Status;
                userGoal.TargetWeight = model.TargetWeight;
                userGoal.EndDate = model.EndDate;
                userGoal.ExpectedDailyCalorieBurnt = model.ExpectedDailyCalorieBurnt;
                userGoal.ExpectedDailyCalorieIntake = model.ExpectedDailyCalorieIntake;
                userGoal.GoalType = model.GoalType;
            }
            var rowChanges = await _unitOfWork.SaveChangesAsync();

            return rowChanges > 0 ? new Response<AddOrUpdateUserGoalDTO>
            {
                IsSuccessful = true,
                Message = $"Task: {model.FitFamerId} was successfully created!"
            } :
            new Response<AddOrUpdateUserGoalDTO>
            {
                IsSuccessful = false,
                Message = "Failed To save changes!"
            };

        }

        public async Task<Response<FindUserGoalDTO>> DeleteAsync(FindUserGoalDTO model)
        {
            FitFamer fitfamer = await _repo.GetSingleByAsync(u => u.Id == model.FitFamerId);

            if (fitfamer is null)
            {
                return new Response<FindUserGoalDTO>
                {
                    Message = $"User with id:{model.FitFamerId} wasn't found",
                    IsSuccessful = false,

                };
            }

            UserGoal userGoal = fitfamer.UserGoals.FirstOrDefault(t => t.Id == model.UserGoalId);
            if (userGoal is not null)
            {
                fitfamer.UserGoals.Remove(userGoal);

                return await _unitOfWork.SaveChangesAsync() > 0 ? new Response<FindUserGoalDTO>
                {
                    Message = $"Task with Title:{userGoal.GoalType} was deleted",
                    IsSuccessful = true
                } :
                new Response<FindUserGoalDTO>
                {
                    IsSuccessful = false,
                    Message = $"Delete Failed"
                };
            }
            return new Response<FindUserGoalDTO>
            {
                IsSuccessful = false,
                Message = $"Task with id:{model.UserGoalId} was not found"
            };
        }


        public async Task<Response<UserGoal>> GetUserGoalAsync(int fitfamerId, int userGoalId)
        {
            FitFamer fitfamer = await _repo.GetSingleByAsync(u => u.Id == fitfamerId);


            if (fitfamer is null)
            {
                return new Response<UserGoal> { Message = "User not found" };
            }

            UserGoal goal = fitfamer.UserGoals.FirstOrDefault(t => t.Id == userGoalId);

            if (goal is null)
            {
                return new Response<UserGoal> { Message = "Goal not found" };
            }

            return new Response<UserGoal> { Result = goal };

        }

        public IEnumerable<UserGoal> GetUserGoalListAsync()
        {
            List<UserGoal> goalList = new List<UserGoal>();

            var goals = goalList;

            return goals;
        }
    }
}
