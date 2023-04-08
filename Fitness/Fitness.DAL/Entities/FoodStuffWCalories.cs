using Fitness.DAL.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Fitness.DAL.Entities
{

    public class FoodStuffWCalories : BaseEntity

    {
        public Guid FoodStuffId { get; set; }
        public FoodStuff FoodStuff { get; set; }     
        [Range(1, 5)]
        public int AmtConsumed { get; set; } = 1;
        public Guid MealLogID { get; set; }
        public MealLog MealLog { get; set; }

     
    }
}
