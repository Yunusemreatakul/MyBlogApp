using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MyPath.Domain.Entities
{
    public class CommentBlogReply
    {
        [Key]
        public int CommentBlogReplyId { get; set; }
        public string Message { get; set; }
        public int SendUserId { get; set; }
        public int CommentBId { get; set; }
        public CommentBlog CommentB { get; set; }

    }
}
