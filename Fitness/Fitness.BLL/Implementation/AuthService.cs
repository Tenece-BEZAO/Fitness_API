
﻿using Fitness.BLL.DTO;
using Fitness.BLL.Interface;
using Fitness.DAL.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Fitness.BLL.Implementation
{
    public class AuthService : IAuthService
    {
        private readonly ILoggerManager _logger;
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;
        private readonly IConfiguration _configuration;
        private User? _user;

        public AuthService(ILoggerManager logger, SignInManager<User> signInManager, UserManager<User> userManager, IConfiguration configuration)
        {
            _configuration = configuration;
            _logger = logger;
            _userManager = userManager;
            _signInManager = signInManager;
        }
        public async Task<Response<FitFamerForAuthDTO>> LogInAsync(FitFamerForAuthDTO authModel)
        {
            try
            {
                _user = await _userManager.FindByEmailAsync(authModel.Email);
                var userPassword = await _userManager.CheckPasswordAsync(_user, authModel.Password);
                if (_user is not null && userPassword is true)
                {
                    return new Response<FitFamerForAuthDTO>
                    {
                        Message = "LogIn successful",
                        IsSuccessful = true,
                    };
                }
                var signInResult = await _signInManager.PasswordSignInAsync(_user, authModel.Password, false, true);
                if(signInResult.Succeeded)
                {
                    var userRoles = await _userManager.GetRolesAsync(_user);
                    var authClaims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, _user.UserName),
                };

                    foreach (var userRole in userRoles)
                    {
                        authClaims.Add(new Claim(ClaimTypes.Role, userRole));
                    }
                    return new Response<FitFamerForAuthDTO>
                    {
                        Message = "LogIn successful",
                        IsSuccessful = true,
                    };
                }
                return new Response<FitFamerForAuthDTO>
                {
                    Message = "LogIn unsuccessful",
                    IsSuccessful = false,
                };
            }
            catch (Exception ex)
            {
                _logger.LogError($"Something went wrong in the {nameof(LogInAsync)} service method {ex}");
                throw;
            }

        }
        public async Task<Response<string>> LogOutAsync()
        {
           await _signInManager.SignOutAsync();
            return new Response<string> 
            {
                Message = "Logged Out",
                IsSuccessful = true,
            };
        }
        public async Task<string> CreateToken()
        {
            try
            {
                _logger.LogInfo("Creates the JWT token");

                var signingCredentials = GetSigningCredentials();
                var claims = await GetClaims();
                var tokenOptions = GenerateTokenOptions(signingCredentials, claims);
                return new JwtSecurityTokenHandler().WriteToken(tokenOptions);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Something went wrong in the {nameof(CreateToken)} service method {ex}");
                throw;
            }

        }

        private static SigningCredentials GetSigningCredentials()
        {
            var key = Encoding.UTF8.GetBytes(Environment.GetEnvironmentVariable("SECRET"));
            var secret = new SymmetricSecurityKey(key);
            return new SigningCredentials(secret, SecurityAlgorithms.HmacSha256);

        }

        private async Task<List<Claim>> GetClaims()
        {
           
            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.Name, _user.UserName)
             };
            var roles = await _userManager.GetRolesAsync(_user);
            foreach (var role in roles)
            {
                claims.Add(new Claim(ClaimTypes.Role, role));
            }
            return claims;
        }

        private JwtSecurityToken GenerateTokenOptions(SigningCredentials signingCredentials, List<Claim> claims)
        {
            var jwtSettings = _configuration.GetSection("JwtSettings");
            var tokenOptions = new JwtSecurityToken
            (
            issuer: jwtSettings["validIssuer"],
            audience: jwtSettings["validAudience"],
            claims: claims,
            expires: DateTime.Now.AddMinutes(Convert.ToDouble(jwtSettings["expires"])),
            signingCredentials: signingCredentials
            );
            return tokenOptions;
        }

    }
}
