using System;
using Fitness.DAL.Enums;

namespace Fitness.DAL.Entities
{
    public class WorkOut : BaseEntity
    {
        public List<FitFamer> FitFamers { get; set; }
        public DateTime Date { get; set; }
        public decimal LiveWeight { get; set; }
    }
}

