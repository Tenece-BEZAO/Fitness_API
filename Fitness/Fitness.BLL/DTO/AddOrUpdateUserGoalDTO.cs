using Fitness.DAL.Entities;
using Fitness.DAL.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fitness.BLL.DTO
{
    public class AddOrUpdateUserGoalDTO
    {
        public GoalType GoalType { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public decimal TargetWeight { get; set; }
        public Status Status { get; set; }
        public int ExpectedDailyCalorieIntake { get; set; }
        public int ExpectedDailyCalorieBurnt { get; set; }
        public Guid FitFamerId { get; set; }
        public int UserGoalID { get; set; }
        [EmailAddress]
        public string Email { get; set;}
    }
}
