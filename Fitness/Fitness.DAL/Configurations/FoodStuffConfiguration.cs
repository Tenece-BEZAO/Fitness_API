using Fitness.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Fitness.DAL.Configurations
{
    public class FoodStuffConfiguration : IEntityTypeConfiguration<FoodStuff>
    {
        public void Configure(EntityTypeBuilder<FoodStuff> builder)
        {
            builder.HasData
                (
                    new FoodStuff
                    {
                        Name = "Yam",
                        Calories = 112,
                        FoodClass = Enums.FoodClass.Carbohydrate
                    },
                    new FoodStuff
                    {
                        Name = "Beans",
                        Calories = 120,
                        FoodClass = Enums.FoodClass.Carbohydrate
                    },
                    new FoodStuff
                    {
                        Name = "Egg",
                        Calories = 92,
                        FoodClass = Enums.FoodClass.Protein
                    },
                    new FoodStuff
                    {
                        Name = "Agbugbu",
                        Calories = 230,
                        FoodClass = Enums.FoodClass.Carbohydrate
                    },
                    new FoodStuff
                    {
                        Name = "Yogurt",
                        Calories = 75,
                        FoodClass = Enums.FoodClass.Protein
                    },
                    new FoodStuff
                    {
                        Name = "Cheese",
                        Calories = 92,
                        FoodClass = Enums.FoodClass.Minerals
                    },
                    new FoodStuff
                    {
                        Name = "Rice",
                        Calories = 300,
                        FoodClass = Enums.FoodClass.Carbohydrate
                    },
                    new FoodStuff
                    {
                        Name = "Pork",
                        Calories = 132,
                        FoodClass = Enums.FoodClass.Fats
                    },
                    new FoodStuff
                    {
                        Name = "Citrus",
                        Calories = 110,
                        FoodClass = Enums.FoodClass.Vitamins
                    },
                    new FoodStuff
                    {
                        Name = "Suya",
                        Calories = 234,
                        FoodClass = Enums.FoodClass.Protein
                    },
                    new FoodStuff
                    {
                        Name = "Garri",
                        Calories = 240,
                        FoodClass = Enums.FoodClass.Carbohydrate
                    }


                );
        }
    }
}
