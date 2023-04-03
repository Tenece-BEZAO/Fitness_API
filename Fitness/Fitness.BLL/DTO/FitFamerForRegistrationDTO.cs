using Fitness.DAL.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fitness.BLL.DTO
{
    public class FitFamerForRegistrationDTO
    {
        [Required(ErrorMessage = "Firstname is required")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Lastname is required")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Username is required")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Password is required")]
        public string Password { get; set; }
        [Required(ErrorMessage = "Password is required")]
        public string ConfirmPassword { get; set; }

        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Phone Number is required")]
        public string PhoneNumber { get; set; }
        [Required(ErrorMessage = "Phone Number is required")]
        public DateTime BirthDate { get; set; }
        public string Gender { get; set; }
        [Required(ErrorMessage = "Height is required")]
        public double Height { get; set; }
        [Required(ErrorMessage = "Current Weight is required")]
        public double CurrentWeight { get; set; }
        [Required(ErrorMessage = "Goal Weight is required")]
        public double GoalWeight { get; set; }
        [Required(ErrorMessage = "ExperienceLevel is required")]
        public ExperienceLevel ExperienceLevel { get; set; }

    }
}
