﻿using System;
using Fitness.DAL.Enums;
using System.ComponentModel.DataAnnotations;

namespace Fitness.BLL.DTO
{
    public class ExerciseForUpdateDto
    {
        [Required(ErrorMessage = "Provide the name value")]
        public string Name { get; set; } = string.Empty;
        [MaxLength(200)]
        public string Description { get; set; }
        public Category Category { get; set; }
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
    }
}

