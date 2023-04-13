using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Fitness.DAL.Entities
{
    public class UserAchievement : BaseEntity
    {
        
        public Guid FitFamerId { get; set; }
        public FitFamer FitFamer { get; set; }
        public Guid AchievementId { get; set; }
        public virtual Achievement Achievement { get; set; }

    }
}
