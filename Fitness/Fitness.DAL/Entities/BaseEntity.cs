using System;
using System.ComponentModel.DataAnnotations;

namespace Fitness.DAL.Entities
{
    public class BaseEntity
    {
        
        public string Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}

