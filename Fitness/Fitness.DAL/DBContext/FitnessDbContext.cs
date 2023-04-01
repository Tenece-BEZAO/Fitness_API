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

            builder.Entity<MealLog>()
                .HasMany(p => p.FoodStuffs)
                .WithMany(p => p.MealLogs)
                .UsingEntity(j => j.HasData
                (
                new { MealLogsName = "Jollof rice", FoodStuffsName = "Rice" },
                new { MealLogsName = "Jollof rice", FoodStuffsName = "Egg" },
                new { MealLogsName = "Jollof rice", FoodStuffsName = "Chicken" }
                ));        

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

        public DbSet<MealLog> MealPlanLogs { get; set; }
        public DbSet<FoodStuff> FoodStuffs { get; set; }
        public DbSet<UserMealLog> UserMeals { get; set; }

    }
}
