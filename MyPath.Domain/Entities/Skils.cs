using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPath.Domain.Entities
{
    public class Skils
    {
        [Key]
        public int SkilsId { get; set; }
        public string IconUrl { get; set; }
        public string SkilName { get; set; }
        public string Description { get; set; }
        public string Rate { get; set; }
        public bool CreatingIsActive { get; set; }
        public bool SkilIsActive { get; set; }
        public string LongDescription { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }

    }
}
