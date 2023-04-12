using System.Reflection.Emit;
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
            builder.Entity<UserAchievement>()
                .HasKey(ua => new { ua.FitFamerId, ua.AchievementId });


            builder.Entity<UserAchievement>()
                .HasOne(ua => ua.FitFamer)
                .WithMany(f => f.UserAchievements)
                .HasForeignKey(ua => ua.FitFamerId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<UserAchievement>()
                .HasOne(ua => ua.Achievement)
                .WithMany(a => a.UserAchievements)
                .HasForeignKey(ua => ua.AchievementId)
                .OnDelete(DeleteBehavior.Cascade);


            builder.Entity<WorkOutExercise>()
       .HasKey(we => new { we.WorkOutId, we.ExerciseId });

            builder.Entity<WorkOutExercise>()
                .HasOne(we => we.WorkOut)
                .WithMany(w => w.WorkOutExercises)
                .HasForeignKey(we => we.WorkOutId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<WorkOutExercise>()
                .HasOne(we => we.Exercise)
                .WithMany(e => e.WorkOutExercises)
                .HasForeignKey(we => we.ExerciseId)
                .OnDelete(DeleteBehavior.Restrict);


            builder.ApplyConfiguration(new RoleConfiguration());

            builder.ApplyConfiguration(new UserGoalConfiguration());
            builder.ApplyConfiguration(new WorkOutConfiguration());


        }

        
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
