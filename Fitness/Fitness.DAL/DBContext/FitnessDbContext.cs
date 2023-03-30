using Fitness.DAL.Configuration;
using Fitness.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace Fitness.DAL.DBContext
{
    public class FitnessDbContext : DbContext
    {

        public DbSet<MealLog> MealPlanLogs { get; set; }
        public DbSet<FoodStuff> FoodStuffs { get; set; }

        public FitnessDbContext(DbContextOptions<FitnessDbContext> options)
            : base(options)
        {

        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MealLog>()
                .HasMany(p => p.FoodStuffs)
                .WithMany(p => p.MealLogs)
                .UsingEntity(j => j.HasData
                (
                new { MealLogsName = "Jollof rice", FoodStuffsName = "Rice" },
                new { MealLogsName = "Jollof rice", FoodStuffsName = "Egg" },
                new { MealLogsName = "Jollof rice", FoodStuffsName = "Chicken"}
                ));

            modelBuilder.ApplyConfiguration(new MealLogConfiguration());
            modelBuilder.ApplyConfiguration(new FoodStuffConfiguration());
        }
    }
}
