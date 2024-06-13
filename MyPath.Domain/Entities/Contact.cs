using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPath.Domain.Entities
{
    public class Contact
    {
        [Key]
        public int ContactId { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Message { get; set; }
        public int SendUserId { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
    }

}

