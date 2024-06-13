using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MyPath.Domain.Entities
{
    public class BlogDetail
    {
        [Key]
        public int BlogDetailId { get; set; }
        public string BlogTitle { get; set; }
        public string Description1 { get; set; }
        public string Description2 { get; set; }
        public string Description3 { get; set; }
        public string Description4 { get; set; }
        public string ImageUrl1 { get; set; }
        public string ImageUrl2 { get; set; }
        public string ImageUrl3 { get; set; }
        public string Contributed { get; set; }
        public int BlogCardId { get; set; }
        public BlogCard BlogCard { get; set; }

        public ICollection<CommentBlog> Comments { get; set; }

    }
}
