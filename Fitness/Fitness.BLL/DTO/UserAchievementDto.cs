using System;
namespace Fitness.BLL.DTO
{
    public class UserAchievementDto
    {

        public string Name { get; set; } = string.Empty;
        public DateTime DateAchieved { get; set; } = DateTime.Now;
        public string Description { get; set; }
    }
}

