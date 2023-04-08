
using Fitness.DAL.Entities;
using Fitness.DAL.Enums;

namespace Fitness.BLL.DTO.Requests
{
    public class MealLogRequest
    {
        public string Name { get; set; }
        public MealTime MealTime { get; set; }
    }
}



