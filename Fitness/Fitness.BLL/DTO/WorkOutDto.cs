using System;
namespace Fitness.BLL.DTO
{
    public class WorkOutDto
    {
        public Guid FitFamerId { get; set; }
        public DateTime WorkOutDate { get; set; }
        public decimal LiveWeight { get; set; }
    }
}

