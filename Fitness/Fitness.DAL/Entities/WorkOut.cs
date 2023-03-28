using System;
using Fitness.DAL.Enums;

namespace Fitness.DAL.Entities
{
    public class WorkOut : BaseEntity
    {
        public string FitFamerId { get; set; }
        public List<FitFamer> FitFamers { get; set; }
        public DateTime Date { get; set; }
        public int Duration { get; set; }
        public IntensityLevel IntensityLevel { get; set; }
    }
}

