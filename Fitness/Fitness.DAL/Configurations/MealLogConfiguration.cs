/*using Fitness.DAL.Entities;
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
                     Id = Guid.Parse("714FC8CF-096C-4F96-8EE3-FB44D542EE37"),
                     Name = "Jollof rice",
                     Calories = 500,
                     MealTime = Enums.MealTime.Lunch
                 },
                 new MealLog
                 {
                     Id = Guid.Parse("3A5E0D39-00AA-41BD-AA88-0AD7ABEBB3A1"),
                     Name = "Porridge Beans",
                     Calories = 290,
                     MealTime = Enums.MealTime.Dinner
                 },
                 new MealLog
                 {
                     Id = Guid.Parse("170C9EE7-BC7F-4F0E-BB42-34CD20C6620D"),
                     Name = "Bread and egg",
                     Calories = 289,
                     MealTime = Enums.MealTime.Breakfast
                 }

                );
        }
    }
}
*/