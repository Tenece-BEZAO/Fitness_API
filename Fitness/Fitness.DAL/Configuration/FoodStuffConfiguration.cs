using Fitness.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Fitness.DAL.Configuration
{
    public class FoodStuffConfiguration : IEntityTypeConfiguration<FoodStuff>
    {
        public void Configure(EntityTypeBuilder<FoodStuff> builder)
        {
            builder.HasData
                (
                    new FoodStuff
                    {
                        Id = Guid.Parse("323A8BF4-BB65-4C20-A2F5-3E9EBF3ADE0F").ToString(),
                        Name = "Yam",
                        Calories = 112,
                        FoodClass = Enums.FoodClass.Carbohydrate
                    },
                    new FoodStuff
                    {
                        Id = Guid.Parse("C758ED73-4B90-44AB-960D-0A608567E34B").ToString(),
                        Name = "Beans",
                        Calories = 120,
                        FoodClass = Enums.FoodClass.Carbohydrate
                    },
                    new FoodStuff
                    {
                        Id = Guid.Parse("ED8E5B0E-A82D-47A8-BCF9-CBC05E3F7C0C").ToString(),
                        Name = "Egg",
                        Calories = 92,
                        FoodClass = Enums.FoodClass.Protein
                    },
                    new FoodStuff
                    {
                        Id = Guid.Parse("26C66B98-0224-487E-99DE-95540DBFBF71").ToString(),
                        Name = "Agbugbu",
                        Calories = 230,
                        FoodClass = Enums.FoodClass.Carbohydrate
                    },
                    new FoodStuff
                    {
                        Id = Guid.Parse("B162696B-7BC0-47A4-AEE3-513E554BA918").ToString(),
                        Name = "Yogurt",
                        Calories = 75,
                        FoodClass = Enums.FoodClass.Protein
                    },
                    new FoodStuff
                    {
                        Id = Guid.Parse("45007EAB-8A9D-4BC9-8B2F-499C74B6F2E4").ToString(),
                        Name = "Cheese",
                        Calories = 92,
                        FoodClass = Enums.FoodClass.Minerals
                    },
                    new FoodStuff
                    {
                        Id = Guid.Parse("C56B3622-C594-47FC-ACA9-C7C4A8004715").ToString(),
                        Name = "Rice",
                        Calories = 300,
                        FoodClass = Enums.FoodClass.Carbohydrate
                    },
                    new FoodStuff
                    {
                        Id = Guid.Parse("913D8E9E-D6C3-4211-9FC2-6E4058247D0C").ToString(),
                        Name = "Pork",
                        Calories = 132,
                        FoodClass = Enums.FoodClass.Fats
                    },
                    new FoodStuff
                    {
                        Id = Guid.Parse("E00AA3F4-11D6-4C5A-8EF1-72DD53DCA75D").ToString(),
                        Name = "Citrus",
                        Calories = 110,
                        FoodClass = Enums.FoodClass.Vitamins
                    },
                    new FoodStuff
                    {
                        Id = Guid.Parse("21306B5B-787B-48AD-8D74-927EBE4B9F59").ToString(),
                        Name = "Suya",
                        Calories = 234,
                        FoodClass = Enums.FoodClass.Protein
                    },
                    new FoodStuff
                    {
                        Id = Guid.Parse("924A93BE-743C-4EA9-BDA8-C7F53D6F49A8").ToString(),
                        Name = "Garri",
                        Calories = 240,
                        FoodClass = Enums.FoodClass.Carbohydrate
                    }


                );
        }
    }
}
