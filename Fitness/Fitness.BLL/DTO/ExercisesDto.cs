using System;
using Fitness.DAL.Enums;
using System.ComponentModel.DataAnnotations;

namespace Fitness.BLL.DTO
{
    public class ExercisesDto
    {

        [Required(ErrorMessage = "Provide the name value")]
        public string Name { get; set; } = string.Empty;
        [MaxLength(200)]
        public string Description { get; set; }
        public Category Category { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;

    }
}

