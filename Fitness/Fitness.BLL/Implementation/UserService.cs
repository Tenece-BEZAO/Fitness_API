using Fitness.BLL.DTO;
using Fitness.BLL.Interface;
using Fitness.DAL.Entities;
using Microsoft.AspNetCore.Identity;


namespace Fitness.BLL.Implementation
{
    public class UserService : IUserService
    {
        private readonly UserManager<User> _userManager;
        private readonly IRepository<FitFamer> _repo;
        private readonly IRepository<User> _userRepo;
        private readonly IUnitOfWork _unitOfWork;

        public UserService(UserManager<User> userManager, IUnitOfWork unitOfWork)
        {
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
                };
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

        public async Task<Response<FitFamerForUpdateDTO>> UpdateAUserAsync(FitFamerForUpdateDTO fitfamer)
        {
            if (fitfamer is null)
            {
                return new Response<FitFamerForUpdateDTO>
                {
                    Message = "No Update Made",
                    IsSuccessful = false,
                };
            }
            try
            {
                var existingUser = await _userManager.FindByEmailAsync(fitfamer.Email);
                if (existingUser is null)
                {
                    return new Response<FitFamerForUpdateDTO>
                    {
                        Message = "User does not exist. Please register an account",
                        IsSuccessful = false,
                    };
                }

                var newUser = new User
                {
                    FirstName = fitfamer.FirstName,
                    LastName = fitfamer.LastName,
                    UserName = fitfamer.UserName,
                    Email = fitfamer.Email,
                };
                var newFitFamer = new FitFamer
                {
                    Height = fitfamer.Height,
                    CurrentWeight = fitfamer.CurrentWeight,
                    ExerciseExperienceLevel = fitfamer.ExperienceLevel,
                };
                var updateUser = await _userManager.UpdateAsync(newUser);

                newFitFamer.UserId = newUser.Id;

                var updateFitFamer = await _repo.UpdateAsync(newFitFamer);

                var result = new Response<FitFamerForUpdateDTO>
                {
                    Message = "Successful",
                    IsSuccessful = true,
                    Result = fitfamer
                };

                return updateUser is not null && updateFitFamer is not null ? result : new Response<FitFamerForUpdateDTO>
                {
                    Message = "Up to Date",
                    IsSuccessful = false,
                    Result = fitfamer
                };
            }
            catch (Exception e)
            {

                return new Response<FitFamerForUpdateDTO>
                {
                    Message = e.Message,
                    IsSuccessful = false,
                    Result = fitfamer
                };
            }

        }
        public async Task<Response<FitFamerForAuthDTO>> DeleteAUserAsync(FitFamerForAuthDTO fitfamer)
        {
            var user = await _userRepo.GetSingleByAsync(u => u.Email == fitfamer.Email && u.PasswordHash == fitfamer.Password);

            if (user is not null)
            {
                await _userRepo.DeleteAsync(user);
                return new Response<FitFamerForAuthDTO>
                {
                    Message = "Account has been successfully deleted",
                    IsSuccessful = true,
                };
            }

            return new Response<FitFamerForAuthDTO>
            {
                Message = "Delete Failed",
                IsSuccessful = false,
            };
        }

        public async Task<Response<FitFamerForRegistrationDTO>> GetAUserAsync(string username)
        {
            var user = _userManager.FindByNameAsync(username);

            if (user is not null)
            {
                return new Response<FitFamerForRegistrationDTO>
                {
                    Message = $"{username} Found",
                    IsSuccessful = true,

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
