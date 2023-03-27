using System;
using Fitness.DAL.Enums;

namespace Fitness.DAL.Entities
{
    public class WorkOut : BaseEntity
    {
        public string UserId { get; set; }
        public User User { get; set; }
        public DateTime Date { get; set; }
        public DateTime Duration { get; set; }
        public IntensityLevel intensityLevel { get; set; }
    }
}

