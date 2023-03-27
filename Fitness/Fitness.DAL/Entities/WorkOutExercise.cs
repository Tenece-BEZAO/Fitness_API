using System;
namespace Fitness.DAL.Entities
{
    public class WorkOutExercise : BaseEntity
    {
        public int WorkOutId { get; set; }
        public int ExerciseId { get; set; }
        public int Sets { get; set; }
        public int Reps { get; set; }
    }
}

