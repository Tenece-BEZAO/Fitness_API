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
    //[PrimaryKey("Name")]
    public class FoodStuff : BaseEntity
    {
        public string? Name { get; set; }
        public FoodClass FoodClass { get; set; }
        public int Calories { get; set; }

    }
}
