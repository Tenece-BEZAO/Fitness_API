namespace Fitness.DAL.Entities
{
    public class WorkOut : BaseEntity
    {
        public DateTime Date { get; set; }
        public decimal LiveWeight { get; set; }
        public string FitFamerId { get; set; }
        public List<FitFamer> FitFamers { get; set; }
    }
}

