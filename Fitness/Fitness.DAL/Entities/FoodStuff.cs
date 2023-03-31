﻿using Fitness.DAL.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fitness.DAL.Entities
{
    public class FoodStuff
    {
        public string Name { get; set; }
        public int Calories { get; set; }
        public FoodClass FoodClass { get; set; }
        public List<FitFamer> FitFamers { get; set; }
    }
}
