using System;
using Fitness.DAL.Enums;

namespace Fitness.DAL.Extensions
{
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

