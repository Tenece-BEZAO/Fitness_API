using System;
using Fitness.DAL.Enums;

namespace Fitness.DAL.Extensions
{
    public static class ExperienceLevelExtension
    {
        public static string? GetStringValue(this ExperienceLevel experience)
        {
            return experience switch
            {
                ExperienceLevel.Beginner => "Beginner",
                ExperienceLevel.Intermediate => "Intermediate",
                ExperienceLevel.Pro => "Pro",
                _ => null
            };
        }
    }
}

