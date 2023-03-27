using System;
namespace Fitness.DAL.Entities
{
    public class Achievement : BaseEntity
    {
        public int UserId { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
    }
}

