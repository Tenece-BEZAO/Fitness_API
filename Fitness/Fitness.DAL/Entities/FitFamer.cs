﻿using Fitness.DAL.Enums;

namespace Fitness.DAL.Entities
{
    public class FitFamer : BaseEntity
    {
        public double Height { get; set; }
        public double CurrentWeight { get; set; }
        public double GoalWeight { get; set; }
        public ExperienceLevel ExperienceLevel { get; set; }
        public string UserId { get; set; }
        public User User { get; set; }
        public string UserGoalId { get; set; }
        public UserGoal UserGoal { get; set; }
        public string WorkOutId { get; set; }
        public WorkOut WorkOut { get; set; }
        public List<Achievement> Achievements { get; set; }
        public List<Exercise> Exercises { get; set; }
        public List<MealLog> MealLogs { get; set; }
        //public List<UserMealLog> UserMealLogs { get; set; }


    }
}
