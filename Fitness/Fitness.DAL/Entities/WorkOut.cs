namespace Fitness.DAL.Entities
{
    public class WorkOut : BaseEntity
    {
        public Guid FitFamerId { get; set; }
        public FitFamer FitFamer { get; set; }
        public DateTime WorkOutDate { get; set; }
        public decimal LiveWeight { get; set; }
        public List<WorkOutExercise> WorkOutExercises { get; set; }
    }
}

