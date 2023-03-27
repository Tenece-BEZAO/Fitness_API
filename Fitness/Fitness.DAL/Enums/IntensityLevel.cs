using System;
namespace Fitness.DAL.Enums
{
    public enum IntensityLevel
    {
        Low, Moderate, Vigorous
    }
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

