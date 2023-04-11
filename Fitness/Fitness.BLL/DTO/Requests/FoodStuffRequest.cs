using Fitness.DAL.Entities;
using Fitness.DAL.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fitness.BLL.DTO.Requests
{


    public class FoodStuffRequest
    {
        public string Name { get; set; }
        public int Calories { get; set; }
        public FoodClass FoodClass { get; set; }
    }

    public class FoodStuffWCaloriesRequest
    {

    }
}



