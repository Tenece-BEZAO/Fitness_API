using System;
using Fitness.DAL.Enums;

namespace Fitness.DAL.Entities
{
    public class Exercise : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public Category Category { get; set; }
        public List<FitFamer> FitFamers { get; set; }
    }
}

