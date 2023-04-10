using Fitness.BLL.DTO;
using Fitness.BLL.Interface;
using Fitness.DAL.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fitness.BLL.Implementation
{
    public class UserGoalService : IUserGoalService
    {
        private readonly UserManager<User> _userManager;
        private readonly IRepository<FitFamer> _repo;
        private readonly IRepository<User> _userRepo;
        private readonly IUnitOfWork _unitOfWork;

        public UserGoalService(UserManager<User> userManager, IRepository<FitFamer> repo, IRepository<User> userRepo, IUnitOfWork unitOfWork)
        {
            _userRepo = userRepo;
            _userManager = userManager;
            _repo = repo;
            _unitOfWork = unitOfWork;

        }
        public async Task<(bool successful, string msg)> AddOrUpdateAsync(AddOrUpdateUserGoalDTO model)
        {
            FitFamer fitFamer = await _repo.GetSingleByAsync(f => f.Id == model.FitFamerId);

            if (fitFamer is null)
            {
                return (false, $"User with id:{model.FitFamerId} wasn't found");
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
                return (true, "Update Successful!");
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

            return rowChanges > 0 ? (true, $"Task: {model.FitFamerId} was successfully created!") : (false, "Failed To save changes!");

        }

        public async Task<(bool successful, string msg)> DeleteAsync(FindUserGoalDTO model)
        {
            // User user = ToDoListDbContext.GetUsersWithToDos().SingleOrDefault(u => u.Id == model.UserId);
            FitFamer fitfamer = await _repo.GetSingleByAsync(u => u.Id == model.FitFamerId);

            if (fitfamer is null)
            {
                return (false, $"User with id:{model.FitFamerId} wasn't found");
            }

            UserGoal userGoal = fitfamer.UserGoals.FirstOrDefault(t => t.Id == model.UserGoalId);
            if (userGoal is not null)
            {
                fitfamer.UserGoals.Remove(userGoal);

                return await _unitOfWork.SaveChangesAsync() > 0 ? (true, $"Task with Title:{userGoal.GoalType} was deleted") : (false, $"Delete Failed");
            }
            return (false, $"Task with id:{model.UserGoalId} was not found");
        }


        /*public (Todo to, string msg) GetTask(int userId, int taskId)
        {
            // User user = ToDoListDbContext.GetUsersWithToDos().SingleOrDefault(u => u.Id == model.UserId);
            User user = null;

            if (user == null)
            {
                return (null, "User not found");
            }

            Todo todo = user.TodoList.FirstOrDefault(t => t.Id == taskId);

            if (todo == null)
            {
                return (null, "Task not found");
            }

            return (todo, "");

        }

        public IEnumerable<Todo> GetTodoList()
        {
            List<Todo> todoList = new List<Todo>();


            // var todos = ToDoListDbContext.GetUsersWithToDos().SelectMany(t => t.TodoList).ToList();
            var todos = todoList;


            return todos;
        }*/
    }
}
