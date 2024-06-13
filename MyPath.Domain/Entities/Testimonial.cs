using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPath.Domain.Entities
{
    public class Testimonial
    {
        [Key]
        public int TestimonialId { get; set; }
        public int SendUserId { get; set; }
        public string Comments { get; set; }
        public DateOnly DateReceived { get; set; }
        public bool IsActive { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }

    }
}
