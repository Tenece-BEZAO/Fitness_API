﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Fitness.DAL.Enums;

namespace Fitness.DAL.Entities
{
    public class WorkOutExercise : BaseEntity
    {
        public IntensityLevel IntensityLevel { get; set; }
        public int Duration { get; set; }
        public int Sets { get; set; }
        public int Reps { get; set; }
        public Guid WorkOutId { get; set; }
        public WorkOut WorkOut { get; set; }
        public Guid ExerciseId { get; set; }
        public Exercise Exercise { get; set; }
       
    }
}

