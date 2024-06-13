using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPath.Domain.Entities
{
    public class CommentBlog
    {
        [Key]
        public int CommendBlogId { get; set; }
        public int SendUserId { get; set; }
        public string Comments { get; set; }
        public int LikeCount { get; set; }
        public DateTime DateReceived { get; set; }
        public int BlogDetailId { get; set; }
        public BlogDetail BlogDetail { get; set; }

        public ICollection<CommentBlogReply> Replies { get; set; }
    }
}
