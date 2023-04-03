using Fitness.DAL.Enums;

namespace Fitness.DAL.Entities
{

    public class FoodStuff : BaseEntity

    {
        public string Name { get; set; }
        public int AmtConsumed { get; set; } = 1;
        public int Calories { get; set; }
        public FoodClass FoodClass { get; set; }

        //public ICollection<MealLog> MealLogs { get; set; }
    }
}
