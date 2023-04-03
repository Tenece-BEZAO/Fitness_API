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

            /*builder.Entity<MealLog>()
                .HasMany(p => p.FoodStuffs)
                .WithMany(p => p.MealLogs)
                .UsingEntity(j => j.HasData
                (
                new {Id = Guid.Parse("955E8EEC-4587-4929-BA3B-1124FE434521"), FoodStuffsId = Guid.Parse("FD01D1D3-2344-43F8-91F9-86254CA5C5B2"), MealLogsId = Guid.Parse("39DB2A63-238B-4C7B-B6FB-B07834198B4E"), MealLogsName = "Jollof rice", FoodStuffsName = "Rice" },
                new {Id = Guid.Parse("3D19D709-F35D-493C-B61B-67D86FA62976"), FoodStuffsId = Guid.Parse("BC137391-D093-4DCB-9DF0-9326B4F526E0"), MealLogsId = Guid.Parse("0DA0A667-5769-4EE2-9755-611DA2EBE343"), MealLogsName = "Jollof rice", FoodStuffsName = "Egg" },
                new {Id = Guid.Parse("39E09E2F-9210-4963-88F2-8B9875CE4C52"), FoodStuffsId = Guid.Parse("2C8F4449-B460-42CF-8843-A62A6C032D63"), MealLogsId = Guid.Parse("87FCE499-E8FB-43D4-BEF2-A463958E9D6B"), MealLogsName = "Jollof rice", FoodStuffsName = "Chicken" }
                ));        */

            builder.ApplyConfiguration(new RoleConfiguration());


            /*builder.ApplyConfiguration(new MealLogConfiguration());
            builder.ApplyConfiguration(new FoodStuffConfiguration());*/
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
