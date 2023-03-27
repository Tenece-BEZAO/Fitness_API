using System;
using Fitness.DAL.Enums;

namespace Fitness.DAL.Extensions
{
    public static class IntensityExtension
    {
        public static string? GetStringValue(this IntensityLevel intensity)
        {
            return intensity switch
            {
                IntensityLevel.Low => "Low",
                IntensityLevel.Moderate => "Moderate",
                IntensityLevel.Vigorous => "Vigorous",
                _ => null
            };
        }
    }
}

