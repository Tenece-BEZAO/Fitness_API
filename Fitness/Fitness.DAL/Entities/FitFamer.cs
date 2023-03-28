using Fitness.DAL.Enums;
using System.ComponentModel.DataAnnotations.Schema;

namespace Fitness.DAL.Entities
{
    public class FitFamer : BaseEntity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int FitFamerId { get; set; }
        public double Height { get; set; }
        public double CurrentWeight { get; set; }
        public double GoalWeight { get; set; }
        public string UserId { get; set; }
        public User User { get; set; }
        public UserGoal UserGoal { get; set; }
        public WorkOut WorkOut { get; set; }
        public ExperienceLevel ExperienceLevel { get; set; }
        public List<Achievement> Achievements { get; set; }
        public List<Exercise> Exercises { get; set; }

    }
}
