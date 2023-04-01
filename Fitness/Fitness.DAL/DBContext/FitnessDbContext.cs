using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace Fitness.DAL.DBContext
{
    public class FitnessDbContext : IdentityDbContext<User>
    {
        public FitnessDbContext(DbContextOptions<FitnessDbContext> options) : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ApplyConfiguration(new RoleConfiguration());


            builder.ApplyConfiguration(new MealLogConfiguration());
            builder.ApplyConfiguration(new FoodStuffConfiguration());
            builder.ApplyConfiguration(new UserGoalConfiguration());
            builder.ApplyConfiguration(new WorkOutConfiguration());

        }

        public DbSet<Admin> Admins { get; set; }
        public DbSet<FitFamer> FitFamers { get; set; }
        public DbSet<Achievement> Achievements { get; set; }
        public DbSet<Exercise> Exercises { get; set; }
        public DbSet<UserGoal> UserGoals { get; set; }
        public DbSet<WorkOut> WorkOuts { get; set; }
        public DbSet<UserAchievement> UserAchievements { get; set; }
        public DbSet<WorkOutExercise> WorkOutExercises { get; set; }
        public DbSet<MealPlanLog> MealPlanLogs { get; set; }
        public DbSet<UserMealLog> UserMealLogs { get; set; }
        public DbSet<FoodStuff> FoodStuff { get; set; }
    }
}
