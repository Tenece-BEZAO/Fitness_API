using Fitness.BLL.DTO;
using Fitness.BLL.Interface;
using Fitness.DAL.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Fitness.BLL.Implementation
{
    public class AuthService : IAuthService
    {
        private readonly ILoggerManager _logger;
        private readonly UserManager<User> _userManager;
        private readonly IConfiguration _configuration;
        

        public AuthService(ILoggerManager logger, UserManager<User> userManager, IConfiguration configuration)
        {
            _configuration = configuration;
            _logger = logger;
            _userManager = userManager;
        }
        public async Task<Response<FitFamerForAuthDTO>> LogInAsync(string email, string password)
        {
            try
            {
                var user = await _userManager.FindByEmailAsync(email);
                var userPassword = await _userManager.CheckPasswordAsync(user, password);
                if (user is not null && userPassword is true)
                {
                    return new Response<FitFamerForAuthDTO>
                    {
                        Message = "LogIn successful",
                        IsSuccessful = true,
                        Result = new FitFamerForAuthDTO
                        {
                            FirstName = user.FirstName,
                            LastName = user.LastName,
                            Email = email,
                            Password = password,
                            UserName = user.UserName,
                        }
                    };
                }
                else
                {
                    return new Response<FitFamerForAuthDTO>
                    {
                        Message = "Email or password incorrect",
                        IsSuccessful = false
                    };
                }
            }
            catch (Exception ex)
            {
                _logger.LogError($"Something went wrong in the {nameof(LogInAsync)} service method {ex}");
                throw;
            }

        }
        public void LogOut(string username, string password)
        {

        }
    }
}
