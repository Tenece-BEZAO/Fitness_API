using Fitness.BLL.DTO;
using Fitness.BLL.Interface;


using Fitness.DAL.Entities;
using Microsoft.AspNetCore.Identity;



using Fitness.DAL.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Threading.Tasks;
using System.Web;


namespace Fitness.BLL.Implementation
{
    public class UserService : IUserService
    {
        private readonly ILoggerManager _logger;
        private readonly UserManager<User> _userManager;
        private readonly IRepository<FitFamer> _repo;
        private readonly IUnitOfWork _unitOfWork;

        public UserService(ILoggerManager logger, UserManager<User> userManager, IUnitOfWork unitOfWork)
        {
            _logger = logger;
            _userManager = userManager;
            _unitOfWork = unitOfWork;
            _repo = _unitOfWork.GetRepository<FitFamer>();
        }
        public async Task<Response<FitFamerForRegistrationDTO>> SignUpAsync(FitFamerForRegistrationDTO fitfamer)
        {
            if (fitfamer is null)
            {
                return new Response<FitFamerForRegistrationDTO>
                {
                    Message = "Invalid User Input",
                    IsSuccessful = false,
                };
            }
            try
            {
                var existingUser = await _userManager.FindByEmailAsync(fitfamer.Email);
                if (existingUser is not null)
                {
                    return new Response<FitFamerForRegistrationDTO>
                    {
                        Message = "User already exists",
                        IsSuccessful = false,
                    };
                }

                var newUser = new User
                {
                    FirstName = fitfamer.FirstName,
                    LastName = fitfamer.LastName,
                    Gender = fitfamer.Gender,
                    BirthDate = fitfamer.BirthDate,
                    UserName = fitfamer.UserName,
                    Email = fitfamer.Email,
                };
                var newFitFamer = new FitFamer
                {
                    Height = fitfamer.Height,
                    CurrentWeight = fitfamer.CurrentWeight,

                    ExerciseExperienceLevel = fitfamer.ExperienceLevel,
                    WorkOutId = fitfamer.WorkOutId,
                };
                var createUser = await _userManager.CreateAsync(newUser, fitfamer.Password);

                newFitFamer.UserId = newUser.Id;
                };
                var createUser = await _userManager.CreateAsync(newUser, fitfamer.Password);

                var createFitFamer = await _repo.AddAsync(newFitFamer);

                var result = new Response<FitFamerForRegistrationDTO>
                {
                    Message = "Successful",
                    IsSuccessful = true,
                    Result = fitfamer
                };

                return createUser is not null && createFitFamer is not null ? result : new Response<FitFamerForRegistrationDTO>
                {
                    Message = "There is an issue with your sign up",
                    IsSuccessful = false,
                    Result = fitfamer
                }; ;
            }
            catch (Exception e)
            {

                return new Response<FitFamerForRegistrationDTO>
                {
                    Message = e.Message,
                    IsSuccessful = false,
                    Result = fitfamer
                };
            }


        }

        public void UpdateAUserAsync()
        {
            /*User user = await _userRepo.GetSingleByAsync(u => u.Id == model.UserId, include: u => u.Include(x => x.TodoList), tracking: true);

            if (user == null)
            {
                return (false, $"User with id:{model.UserId} wasn't found");
            }

            Todo task = user.TodoList.SingleOrDefault(t => t.Id == model.TaskId);


            if (task != null)
            {

                _mapper.Map(model, task);

                //
                // task.Title = model.Title;
                // task.Description = model.Description;
                // task.Priority = (model.Priority ?? Priority.Normal);
                // task.DueDate = model.DueDate;

                await _unitOfWork.SaveChangesAsync();
                return (true, "Update Successful!");
            }

            // var newTask = _mapper.Map<AddOrUpdateTaskVM,Todo>(model);
            var newTask = _mapper.Map<Todo>(model);

            // var newTask = new Todo
            // {
            //  
            //     Title = model.Title,
            //     Description = model.Description,
            //     Priority = model.Priority ?? Priority.Normal,
            //     DueDate = model.DueDate,
            //
            // };
            user.TodoList.Add(newTask);

            var rowChanges = await _unitOfWork.SaveChangesAsync();

            return rowChanges > 0 ? (true, $"Task: {model.Title} was successfully created!") : (false, "Failed To save changes!");
*/

        }
        public async Task<string> DeleteAUserAsync(int id)
        {
            FitFamer fitfamer = await _repo.GetSingleByAsync(u => u.Id == id);

            if (fitfamer is null)
            {
                return ($"User with id:{id} wasn't found");
            }

            await _repo.DeleteByIdAsync(id);
            return "Successfully deleted";
        }

        public async Task<Response<FitFamerForRegistrationDTO>> GetAUserAsync(string id)
        {
            var user = _userManager.FindByIdAsync(id);

            if (user is not null)
            {
                return new Response<FitFamerForRegistrationDTO>
                {
                    Message = "User Found",
                    IsSuccessful = true,
                    Result = new FitFamerForRegistrationDTO
                    {
                        FirstName = user.Result.FirstName,
                        LastName = user.Result.LastName,
                    }
                };
            }
            return new Response<FitFamerForRegistrationDTO>
            {
                Message = "User not found",
                IsSuccessful = false,
            };

        }

    }
}
