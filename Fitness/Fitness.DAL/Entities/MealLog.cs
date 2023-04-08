using Fitness.DAL.Enums;

namespace Fitness.DAL.Entities
{
    public class MealLog : BaseEntity
    {
        public string Name { get; set; }
        public int Calories { get; }
        public MealTime MealTime { get; set; }
        public IList<FoodStuffWCalories> FoodStuffWCalories { get; set; }
        public Guid FitFamerId { get; set; }
        public FitFamer FitFamer { get; set; }          
    }
}
