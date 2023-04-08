/*using Fitness.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Fitness.DAL.Configurations
{
    public class FoodStuffConfiguration : IEntityTypeConfiguration<FoodStuffWCalories>
    {
        public void Configure(EntityTypeBuilder<FoodStuffWCalories> builder)
        {
            builder.HasData
                (
                    new FoodStuffWCalories
                    { 
                        Id = Guid.Parse("C2586585-4E78-4B50-A512-B6BB4A7F8CD8"),
                        Name = "Yam",
                        Calories = 112,
                        FoodClass = Enums.FoodClass.Carbohydrate
                    },
                    new FoodStuffWCalories
                    {
                        Id = Guid.Parse("969BFB44-1B06-4312-A40F-5E15A652CA52"),
                        Name = "Beans",
                        Calories = 120,
                        FoodClass = Enums.FoodClass.Carbohydrate
                    },
                    new FoodStuffWCalories
                    {
                        Id = Guid.Parse("E9896FCC-761D-42CB-859B-E223741714BB"),
                        Name = "Egg",
                        Calories = 92,
                        FoodClass = Enums.FoodClass.Protein
                    },
                    new FoodStuffWCalories
                    {
                        Id = Guid.Parse("9272380F-6C07-450E-B06D-12018BA0396D"),
                        Name = "Agbugbu",
                        Calories = 230,
                        FoodClass = Enums.FoodClass.Carbohydrate
                    },
                    new FoodStuffWCalories
                    {
                        Id = Guid.Parse("D55A8F8F-081B-4CEF-98EA-CDC0A72B9105"),
                        Name = "Yogurt",
                        Calories = 75,
                        FoodClass = Enums.FoodClass.Protein
                    },
                    new FoodStuffWCalories
                    {
                        Id = Guid.Parse("9408E047-137B-4F27-8AEC-33B491001E17"),
                        Name = "Cheese",
                        Calories = 92,
                        FoodClass = Enums.FoodClass.Minerals
                    },
                    new FoodStuffWCalories
                    {
                        Id = Guid.Parse("FEB0B783-791D-48A3-9598-6D746AFDE2D6"),
                        Name = "Rice",
                        Calories = 300,
                        FoodClass = Enums.FoodClass.Carbohydrate
                    },
                    new FoodStuffWCalories
                    {
                        Id = Guid.Parse("CF789ABB-BE39-44C1-A93A-EC7CD8C33E25"),
                        Name = "Pork",
                        Calories = 132,
                        FoodClass = Enums.FoodClass.Fats
                    },
                    new FoodStuffWCalories
                    {
                        Id = Guid.Parse("4E19BA3B-A80F-4D21-86D5-FF8DF834FC26"),
                        Name = "Citrus",
                        Calories = 110,
                        FoodClass = Enums.FoodClass.Vitamins
                    },
                    new FoodStuffWCalories
                    {
                        Id = Guid.Parse("B197D5F0-F36A-45FA-A801-235168B45AF1"),
                        Name = "Suya",
                        Calories = 234,
                        FoodClass = Enums.FoodClass.Protein
                    },
                    new FoodStuffWCalories
                    {
                        Id = Guid.Parse("B9E2C777-5BCF-46C0-9164-4B586F169B30"),
                        Name = "Garri",
                        Calories = 240,
                        FoodClass = Enums.FoodClass.Carbohydrate
                    }


                );
        }
    }
}
*/