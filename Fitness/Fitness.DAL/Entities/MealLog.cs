using Fitness.DAL.Enums;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fitness.DAL.Entities
{
    public class MealLog : BaseEntity
    {
        [Required]
        public Guid MealPlanLogId { get; set; }
        public string? Name { get; set; }
        [Required]
        public int Calories { get; set; }
        [Required]
        public MealTime MealTime { get; set; }
        public ICollection<FoodStuff> FoodStuffs { get; set; }
    }
}
