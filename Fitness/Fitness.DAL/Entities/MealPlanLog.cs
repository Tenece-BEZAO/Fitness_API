using Fitness.DAL.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fitness.DAL.Entities
{
        public class MealPlanLog : BaseEntity
        {
            public int Calories { get; set; }
            public MealTime MealTime { get; set; }
            public IList<FoodStuff> FoodStuff { get; set; }

        }
    }
