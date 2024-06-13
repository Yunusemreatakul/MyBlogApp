using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPath.Domain.Entities
{
    public class User
    {
        [Key]
        public int UserId { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public ICollection<About> Abouts { get; set; }
        public int RoleId { get; set; }
        public Role Role { get; set; }
        public int ProfileId { get; set; }
        public Profile Profile { get; set; }
        public ICollection<Skils> Skills { get; set; }
        public ICollection<Client> Clients { get; set; }
        public ICollection<Testimonial> Testimonials { get; set; }
        public ICollection<Contact> Contacts { get; set; }
        public ICollection<BlogCard> BlogCards { get; set; }
        public ICollection<Portfolio> Portfolios { get; set; }
        public ICollection<CategoryPortfolio> CategoryPortfolios { get; set; }
        public ICollection<Experience> Experiences { get; set; }
        public ICollection<Education> Educations { get; set; }
    }
}
