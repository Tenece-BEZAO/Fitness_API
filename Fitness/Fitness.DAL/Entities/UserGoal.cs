using System;
using System.Net.NetworkInformation;
using Fitness.DAL.Enums;

namespace Fitness.DAL.Entities
{
    public class UserGoal : BaseEntity
    {
        public GoalType GoalType { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public decimal TargetWeight { get; set; }
        public Status Status { get; set; }
        public List<FitFamer> FitFamers { get; set; }
    }
}

