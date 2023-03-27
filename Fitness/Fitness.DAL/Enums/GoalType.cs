using System;
namespace Fitness.DAL.Enums
{
    public enum GoalType
    {
        LoseWeight, GainWeight, MaintainWeight
    }
    public static class GoalTypeExtension
    {
        public static string? GetStringValue(this GoalType goal)
        {
            return goal switch
            {
                GoalType.GainWeight => "GainWeight",
                GoalType.LoseWeight => "LoseWeight",
                GoalType.MaintainWeight => "MaintainWeight",
                _ => null
            };
        }
    }
}

