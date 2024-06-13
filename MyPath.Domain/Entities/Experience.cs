using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPath.Domain.Entities
{
    public  class Experience
    {
        [Key]
        public int ExperienceId { get; set; }
        public string authority { get; set; }
        public DateOnly StartDate { get; set; }
        public DateOnly FinishDate { get; set; }
        public string Description { get; set; }
        public string JobDefinition { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }

    }
}
