using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPath.Domain.Entities
{
    public class BlogCard
    {
        [Key]
        public int BlogCardId { get; set; }
        public string ImageUrl { get; set; }
        public DateOnly DateReceived { get; set; }
        public string BlogTitle { get; set; }
        public string ShortDescription { get; set; }

        public string CategoryBlog { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }

        

        public int BlogDetailId { get; set; }
        public BlogDetail BlogDetail { get; set; }

    }
}
