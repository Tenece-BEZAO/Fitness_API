using Fitness.DAL.Configurations;
using Fitness.DAL.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

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

        public DbSet<MealLog> MealPlanLogs { get; set; }
        public DbSet<FoodStuffWCalories> FoodStuffsWCalories { get; set; }
        public DbSet<FoodStuff> FoodStuffs { get; set; }

    }
}
