using System;
using Fitness.DAL.Enums;

namespace Fitness.DAL.Entities
{
    public class WorkOut : BaseEntity
    {
        public int UserId { get; set; }
        public DateTime Date { get; set; }
        public DateTime Duration { get; set; }
        public IntensityLevel intensityLevel { get; set; }
    }
}

