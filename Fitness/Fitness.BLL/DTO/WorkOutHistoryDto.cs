using System;
using Fitness.DAL.Entities;
using Fitness.DAL.Enums;

namespace Fitness.BLL.DTO
{
    public class WorkOutHistoryDto
    {
        public IntensityLevel IntensityLevel { get; set; }
        public int Duration { get; set; }
        public int Sets { get; set; }
        public int Reps { get; set; }
        public Guid WorkOutId { get; set; }
       public Guid ExerciseId { get; set; }
       
       
    }
}

