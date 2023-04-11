namespace Fitness.DAL.Entities
{
    public class UserAchievement : BaseEntity
    {
        public Guid FitFamerId { get; set; }
        public FitFamer FitFamer { get; set; }
        public string AchievementId { get; set; }
        public virtual Achievement Achievement { get; set; }
    }
}
