using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fitness.DAL.Entities
{
    public class Admin : BaseEntity
    {
        public string UserId { get; set; }
        public User User { get; set; }
    }
}
