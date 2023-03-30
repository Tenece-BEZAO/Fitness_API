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
        }
    }
}
