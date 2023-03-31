using Fitness.DAL.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fitness.DAL.Entities
{
    public class UserMealLog : MealLog
    {
        public List<FitFamer> FitFamers { get; set; }

    }


}
