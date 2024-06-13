using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPath.Domain.Entities
{
    public class Client
    {
        [Key]
        public int ClientId { get; set; }
        public string CompanyName { get; set; }
        public string LogoUrl { get; set; }
        public string WebSiteUrl { get; set; }
        public bool IsActive { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }


    }

}
