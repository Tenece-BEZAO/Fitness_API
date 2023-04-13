namespace Fitness.DAL.Entities
{
    public class Achievement : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public List<UserAchievement> UserAchievements { get; set; }


    }
}

