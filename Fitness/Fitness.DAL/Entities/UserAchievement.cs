using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fitness.DAL.Entities
{

  
    public class UserAchievement : BaseEntity
    { 
        public string FitFamerId { get; set; }
        public FitFamer FitFamer { get; set; }
        public string AchievementId { get; set; }
        public virtual Achievement Achievement { get; set; }
    }
}
