namespace Fitness.DAL.Entities
{
    public class WorkOut : BaseEntity
    {
        public string Name { get; set; }
        //public DateTime Date { get; set; }
        public decimal LiveWeight { get; set; }
        public List<FitFamer> FitFamers { get; set; }
    }
}

