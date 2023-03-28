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
        public int AdminId { get; set; }
        public string FitFamerId { get; set; }
        public FitFamer FitFamer { get; set; }
    }
}
