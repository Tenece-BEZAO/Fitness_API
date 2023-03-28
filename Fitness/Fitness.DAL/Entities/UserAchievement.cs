using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fitness.DAL.Entities
{
    public class UserAchievement
    {
        public int Id { get; set; }
        public string FitFamerId { get; set; }
        public FitFamer FitFamer { get; set; }
        public string AchievementId { get; set; }
        public Achievement Achievement { get; set; }
    }
}
