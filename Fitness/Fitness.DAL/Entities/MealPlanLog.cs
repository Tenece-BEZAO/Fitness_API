using Fitness.DAL.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fitness.DAL.Entities
{
    //inherit base entity when it is fixed
    public class MealPlanLog
    {
        public Guid Id { get; set; }
        public int Calories { get; set; }
        public MealTime MealTime { get; set; }
        public IList<FoodStuff> FoodStuff { get; set; }
        public DateOnly CreatedAt { get; set; }
    }
}
