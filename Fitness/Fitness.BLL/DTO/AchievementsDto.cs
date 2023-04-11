﻿using System;
using System.ComponentModel.DataAnnotations;

namespace Fitness.BLL.DTO
{
    public class AchievementsDto
    {

        [Required(ErrorMessage = "Provide the name value")]
        public string Name { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        [MaxLength(200)]
        public string Description { get; set; }
    }
   
}

