using Fitness.DAL.Enums;

namespace Fitness.DAL.Entities
{
    public class MealLog : BaseEntity
    {
        public string? Name { get; set; }
        public int Calories { get; set; }
        public MealTime MealTime { get; set; }
        public ICollection<FoodStuff> FoodStuffs { get; set; }


    }
}
