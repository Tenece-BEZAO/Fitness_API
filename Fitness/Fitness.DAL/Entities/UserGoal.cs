using System;
using Fitness.DAL.Enums;

namespace Fitness.DAL.Entities
{
    public class UserGoal : BaseEntity
    {
        public int UserId { get; set; }
        public GoalType GoalType { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int CurrentProgress { get; set; }
    }
}

