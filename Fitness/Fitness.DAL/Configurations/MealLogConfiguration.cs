using Fitness.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Fitness.DAL.Configurations
{
    public class MealLogConfiguration : IEntityTypeConfiguration<MealLog>
    {
        public void Configure(EntityTypeBuilder<MealLog> builder)
        {
            builder.HasData
                (
                 new MealLog
                 {
                     Name = "Jollof rice",
                     Calories = 500,
                     MealTime = Enums.MealTime.Lunch
                 },
                 new MealLog
                 {
                     Name = "Porridge Beans",
                     Calories = 290,
                     MealTime = Enums.MealTime.Dinner
                 },
                 new MealLog
                 {
                     Name = "Bread and egg",
                     Calories = 289,
                     MealTime = Enums.MealTime.Breakfast
                 }

                );
        }
    }
}
