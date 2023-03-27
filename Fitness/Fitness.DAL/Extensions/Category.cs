using System;
using Fitness.DAL.Enums;

namespace Fitness.DAL.Extensions
{
    public static class CategoriesExtension
    {
        public static string? GetStringValue(this Category workOutType)
        {
            return workOutType switch
            {
                Category.Cardio => "Cardio",
                Category.Strength => "Strength",
                Category.Stretches => "Stretches",
                _ => null
            };
        }
    }
}

