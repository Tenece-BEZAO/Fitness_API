using System;
namespace Fitness.DAL.Entities
{
    public class WorkOutExercise : BaseEntity
    {
        public string WorkOutId { get; set; }
        public WorkOut WorkOut { get; set; }
        public string ExerciseId { get; set; }
        public Exercise Exercise { get; set; }
        public int Sets { get; set; }
        public int Reps { get; set; }
    }
}

