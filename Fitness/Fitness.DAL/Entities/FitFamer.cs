﻿using Fitness.DAL.Enums;

namespace Fitness.DAL.Entities
{
    public class FitFamer : BaseEntity
    {
        public double Height { get; set; }
        public double CurrentWeight { get; set; }
        public ExperienceLevel ExerciseExperienceLevel { get; set; }
        public string UserId { get; set; }
        public User User { get; set; }
        public List<UserGoal> UserGoals { get; set; }
        public List<UserAchievement> UserAchievements { get; set; }
        public List<MealLog> MealLogs { get; set; }
        


    }
}
