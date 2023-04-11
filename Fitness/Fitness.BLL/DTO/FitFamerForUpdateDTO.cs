using Fitness.DAL.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fitness.BLL.DTO
{
    public class FitFamerForUpdateDTO
    {
        
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string OldPassword { get; set; }
        public string NewPassword { get; set; }
        
        [Compare("NewPassword")]
        public string? ConfirmNewPassword { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime BirthDate { get; set; }
        public double Height { get; set; }
        public double CurrentWeight { get; set; }
        public ExperienceLevel ExperienceLevel { get; set; }
    }
}
