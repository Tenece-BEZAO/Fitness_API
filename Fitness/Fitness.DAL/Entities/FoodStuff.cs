using Fitness.DAL.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fitness.DAL.Entities
{
    public class FoodStuff : BaseEntity
    {
        [Required]
        public string Name { get; set; }
        public int AmtConsumed { get; set; } = 1;
        [Required]
        public int Calories { get; set; }
        [Required]
        public FoodClass FoodClass { get; set; }
        public ICollection<MealLog> MealLogs { get; set; }
    }
}
